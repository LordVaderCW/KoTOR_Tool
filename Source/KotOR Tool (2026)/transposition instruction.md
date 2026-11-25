# VB.NET to C# transposition instructions

## Objective and boundaries

Transpose reusable KoTOR functionality into the C# `ktlib` library in independently reviewable stages, using the VB.NET application as read-only reference material. Future applications must be able to consume the library without loading `frmMain`, user settings, game installations or WinForms.

Work in the current checkout, `treya/v1.0.3.5`. The older contributor guidance names `treya/v.1.0.3.4`; inspect status and branch before every stage, preserve existing work, and do not switch branches or import another implementation automatically.

**User constraint: do not change the main application.** Do not edit its VB sources, project references, designers, resources, runtime configuration, or behavior. Do not remove or replace VB implementations. Existing solution repairs and the user-added solution entry for `ktlib` must be preserved. Application integration is outside the authorized scope and requires an explicit later instruction.

The current dependency direction is `ktlib -> .NET Framework`. Neither project references the other. The library must never reference the application. Both target .NET Framework 4.6.2; `ktlib` is managed AnyCPU, while the application remains x86 for its native dependencies. Do not upgrade frameworks or port to modern .NET as part of a language translation.

## Stage ledger

| Stage | Scope | Current state | Completion evidence |
| --- | --- | --- | --- |
| 1 | Source inventory, responsibility map and library boundary | Initial inventory complete | [225-file inventory](ktlib/migration-inventory.md); 218 application VB compile entries; detailed method review remains part of each port |
| 2 | Standalone SSF binary read/write counterpart | Implemented and tested independently | `SoundSetCodec`; 4,978 checks against expected bytes and the unchanged VB implementation; no application integration |
| 3 | Independent resource codecs and data models, one subsystem per change | 3.1 RIM, 3.2 BIFF + KEY, 3.3 ERF, 3.4 2DA complete; remaining slices not started | RIM 2,115; BIFF 3,406; KEY 488; ERF 2,805; 2DA 5,419 checks; VB comparisons and documented corrections |
| 4 | Application services and orchestration behind explicit dependencies | Not started | Isolated file/process/path tests; reusable contracts; no global application state in library |
| 5 | Possible future application integration | Out of scope; requires explicit later instruction | No application changes permitted under the current instruction |

This ledger is not authorization for a single wholesale rewrite. Work on one bounded slice at a time. Finish its checks and record remaining limits before beginning the next slice. Do not declare all functionality examined merely because a source scan found it.

## Stage 1: inventory and classify

Use [migration-inventory.md](ktlib/migration-inventory.md) to locate every application source file, declared type, callable name, build inclusion and detected dependency. It includes designers, assembly metadata, uncompiled sources and the Python project-maintenance utility. Binary-only managed/native dependencies have no transposable source in this checkout; see [dependencies.md](dependencies.md).

For each selected slice, read the full implementation, its directory guide and every caller. Record its actual input/output contract, data ownership, serialized representation, side effects, game-specific branches and dependency direction. Text-scanned flags are leads, not proof of isolation. Add a per-slice contract to the library guide before implementing its C# counterpart. Do not delete the VB implementation.

Classify responsibility as binary codec, domain model, lookup service, persistence, process/network service, presentation adapter, UI/designer or developer tooling. Do not create empty C# copies of every VB type. Only introduce classes with implemented, exercised responsibilities.

## Stage 2: SSF pilot contract

The port implements the existing application's behavior, not a new SSF format interpretation:

- Read 40 signed 32-bit little-endian references at absolute byte offset 12. Preserve every reference, including the 12 slots not displayed by the 28-slot editor, negative values and unknown IDs.
- Preserve the legacy reader's tolerance: it ignores header contents, the stored offset and trailing bytes. Writing emits `SSF V1.1`, offset 12 and exactly 40 references (172 bytes). Arbitrary headers/trailing bytes were not retained by the old writer and are not retained by this compatibility codec. Full lossless document preservation would be a separate change with its own fixtures.
- Leave settings, TLK resolution, `Object` index conversions, invalid-index sentinel `-999`, the historical 41-element backing array and binary operations unchanged in VB. C# receives streams and integer arrays only, in its own independent implementation.
- C# leaves caller streams open, including on read failure. Original VB stream ownership and cleanup remain untouched. The test host compiles the unchanged VB file separately with settings/TLK substitutes; it is not an application adapter.
- Do not add header validation, change the slot count, normalize IDs, or reinterpret a game format while translating languages.

Synthetic parity is established. Copied real-game fixtures can strengthen format coverage in a later library-only stage. The automated tests simulate both game contexts; they do not establish real-game or UI coverage. Application integration and editor smoke testing are deferred until explicitly requested.

## Stage 3: resource code and models

Suggested order, subject to dependency review:

1. RIM records and extraction; BIFF entries/archive streams and KEY mappings. Keep resource IDs and display-extension lookup separate.
2. ERF/MOD/SAV archive reading/writing, then 2DA tables and TLK text/sound lookups. Preserve encoding, entry ordering, duplicate identity and missing values.
3. GFF field/struct/list/localization data and binary codec. Separate UI binding and TLK/2DA lookup before moving the parser; retain unknown fields and type widths. Only then move UTC/UTD/UTI/UTM/UTP/UTS/UTT/UTW and dialog schema operations.
4. Image decoding/export, walkmesh geometry and map/project models. Review drawing/native dependencies, pixel ownership, coordinate conventions and persisted type identity individually.

Use namespaces such as `ktlib.Formats.Ssf`, `ktlib.Formats.Rim` and `ktlib.Formats.Gff`. Use normal C# types and typed contracts at new boundaries; keep legacy names/signatures in adapters where callers or serialization require them. Do not change XML member names or binary-serialized assembly/type identities accidentally.

### Iteration 3.1 — RIM read/extract (complete, 2026-11-16)

Implemented standalone `ktlib.Formats.Rim.RimArchive` and immutable `RimEntry`. Read the original reader/entry source and reviewed entry-list, search, extraction and tree-node consumers. The library does not acquire the application extension registry or game/path/UI state. See the [RIM contract](ktlib/Formats/Rim/README.md) for exact source behavior, API and deviations.

Compatibility findings: the original reader's resource-ID property uses entry bytes 18–19, not the ignored bytes 20–23. The C# property is named `LegacyResourceId` to make this explicit. Checked positive-Short/Integer limits are retained; unknown types within that range are extractable. No format-correction work is hidden in this port. Complete original bytes, including unknown header/table/trailing data, can be copied back unchanged.

Deliberate library differences are eager table/payload range validation, immutable metadata and an owned input snapshot. Valid input is compared against VB; malformed input behavior is documented and tested separately. No writer or integration code was added.

Validation: 2,115 RIM assertions pass; the existing 4,978 SSF assertions still pass. Full-framework Debug/x86 solution rebuild: 0 errors, unchanged 187-warning baseline. The isolated original VB test host emits its existing BC42025 warning; the new C# code adds no warnings. Hash verification confirms all 370 non-generated application/solution files are unchanged from this iteration's start, including the user's existing solution/project modifications. No live game data or UI was used.

Iteration 3.1 stopped at RIM. The subsequent user instruction explicitly combined BIFF and KEY in iteration 3.2 below. Application integration remains outside scope.

### Iteration 3.2 — BIFF and KEY together (complete, 2026-11-16)

The user requested both BIFF and KEY together. Added `BiffArchive` and `BiffResourceInfo`, plus `KeyIndex`, `KeyResource`, `KeyBiffFile` and `LegacyKeyLayout`. This is standalone library work; the existing VB implementations and application reference graph remain unchanged.

BIFF supports stream-based variable-resource metadata/extraction and temporary path helpers, preserving signed IDs/types, character-based header reading, absolute table offsets and table-index access. Bounds/short-read failures and stream ownership are explicit. Fixed resources remain unsupported, as in the original reader. See the [BIFF contract](ktlib/Formats/Biff/README.md).

KEY supports BIFF file records (the legacy `BIFFEntry` actually belongs to KEY), ordered resource records, name/type lookups, signed filtering, filename normalization, caller-supplied display-extension maps, packed-ID splitting and BIFF resolution. Complete original KEY bytes are retained. `LegacyKeyLayout` reproduces both games' declared-size heuristics, including K2 alternatives; these heuristics are not integrity/security validation. See the [KEY contract](ktlib/Formats/Key/README.md).

Compatibility findings: KEY lookups trim trailing NULs, whereas standalone old `KeyEntry` constructors stop at the first NUL; the library follows the index lookup behavior. Packed IDs retain signed arithmetic-shift behavior; invalid BIFF indexes fail explicitly. Duplicate lookups retain first-match behavior; duplicate map keys and derived BIFF names fail. Stateless maps eliminate the legacy missing-name cache side effect. File metadata is not automatically treated as a safe filesystem path.

Validation: 3,406 BIFF assertions and 488 KEY/combined assertions pass. The combined tests resolve a name/type to the selected BIFF/local index and compare extracted bytes with the original VB path. Both K1/K2 layout rules and every K2 alternate-size combination are tested on synthetic KEY records. Tests also cover a virtual 2.4GB table without a large allocation, short-read streams, stream/file disposal, culture-sensitive lookups, malformed tables and unknown data. SSF (4,978) and RIM (2,115) regressions pass. Full-framework Debug/x86 solution rebuild: 0 errors, unchanged 187 warnings. The original VB KEY test host emits existing BC42025; C# adds no warnings.

Hash verification confirms all 370 non-generated application/solution files are unchanged from the start of this iteration. No live game data, editor session or plugin executable was used; real-game/UI coverage is not claimed.

Iteration 3.2 stopped after BIFF + KEY. ERF-family reading/writing is completed in iteration 3.3 below; application integration remains outside scope.

### Iteration 3.3 — ERF-family read/write (complete, 2026-11-16)

Added `ErfArchive`, immutable `ErfEntry`, `ErfResource` and `ErfLocalizedString`, and `ErfWriter`. Reading/extraction uses an owned byte snapshot. Creation accepts explicit metadata/payloads and a build date, returning archive bytes without filesystem or UI dependencies. Exact copying of an existing archive retains its full header, reserved fields, localized block, padding and trailing bytes. Creation of a new archive is a separate API and does not imply preservation of unprovided metadata.

Review exposed legacy defects that prevent safe round trips: the VB writer declares 24-byte keys but emits 30; the VB reader ignores its stored resource-table offset; the localized-string constructor loses the language ID; missing-name lookup defaults to index zero; TPC preview can cross resource boundaries. The C# implementations correct these behaviors explicitly. Tests demonstrate the old behavior and validate the corrected output. New serialization uses actual encoded byte sizes and fixed byte widths. See the [ERF contract](ktlib/Formats/Erf/README.md) for source-derived layout, numeric limits, localization conventions and all deliberate differences. No whole-byte parity claim is made for the faulty legacy multi-entry writer.

Validation: 2,805 assertions cover ERF/MOD/SAV/HAK metadata/extraction and creation round trips; corrected output is also read by unchanged VB on common layouts. Independent assertions check headers, offsets, strides, dates, language IDs, Unicode replacement and reserved bytes. Whole-byte legacy writer parity is checked on valid zero-entry output, while malformed legacy entry output is inspected without attempting dangerous extraction. Synthetic malformed ranges, duplicate/unknown resources, empty payloads, separated tables, numeric bounds and snapshot ownership are tested.

All earlier suites pass: SSF 4,978, RIM 2,115, BIFF 3,406, KEY 488 (13,792 total including ERF). Full-framework Debug/x86 solution rebuild passes with 0 errors and the same 187 warnings. The VB reference host retains existing BC42104; new C# code adds no warnings. Hash verification confirms all 370 non-generated application/solution files unchanged. Real-game fixture and UI coverage remain unclaimed; only synthetic temporary files were used.

Iteration 3.3 stopped after ERF. The next 2DA slice is completed in iteration 3.4 below. No application integration is authorized.

### Iteration 3.4 — 2DA and base-item helpers (complete, 2026-11-16)

Added `TwoDaCodec`, immutable `TwoDaTable`, `BaseItemCatalog` and immutable `BaseItemInfo`. Reviewed the original table/helper classes, data-only `TreeBaseItem`, GFF/editor callers and the editor binary-save routine. Reading preserves columns, labels, row/cell order, duplicate identities and the `****` missing marker. Exact original-byte copying retains header/size-word/trailing data. Canonical writing is deterministic, interns strings in first-occurrence order and writes unsigned offsets plus an explicit pool size. Zero-row/zero-column tables are supported.

Corrections are explicit: named-row lookup no longer advances to the next row; complete row APIs distinguish cells from labels. The original row array includes an unassigned final element. The editor writer's VB array upper bound includes a spare size slot (it is not an out-of-bounds write), but the computed size is never written to the reserved word in the file. C# writes that word and supports the full UInt16 range instead of CShort's positive range. The original UI save routine was reviewed, not launched or modified; no byte parity is claimed for it. See the [2DA contract](ktlib/Formats/TwoDa/README.md).

Base-item helpers accept a text-lookup callback and caller-owned TextWriter. Names/type/label/slots match the original helper, including distinct list/print fallbacks. To retain VB numeric semantics exactly, the C# project now explicitly references the .NET Framework Microsoft.VisualBasic assembly for IsNumeric and integer conversion. This is not an application reference. Hex/octal input, midpoint rounding, culture-specific numbers and overflow are tested. Actual TLK reading remains outside this slice.

Validation: 5,419 2DA/base-item assertions pass, including original-VB readback of C# output, unsigned-offset and 65535-byte pool limits, missing values, malformed data, zero dimensions, duplicate lookup and ownership. Previous suites pass unchanged; all six suites total 19,211 assertions. Final full-framework Debug/x86 and Release/x86 solution rebuilds both pass with 0 errors and the existing 187 warnings. The isolated VB reference retains five BC42104 warnings; C# introduces none. All 370 non-generated application/solution files were hash-verified unchanged. Only synthetic data and stub TLK lookups were used; real-game/editor behavior is untested.

**Stop here for this iteration.** Next bounded slice: TLK text/sound lookup and its data contracts. Keep dialog/GFF/UI logic out of that slice and retain the main application unchanged.

## Stage 4: services

Extract settings/path context, project persistence, resource lookup and plugin commands only after separating UI and global state. Pass required paths and game context explicitly. Keep settings location policy and prompts in the application. Downloads, command INIs, manifests and plugin executables remain untrusted inputs; test with temporary roots and harmless process fixtures. Do not execute plugin payloads merely to validate a translation.

NCS/model export and plugin workflows move after their resource and process dependencies. Audio playback needs an explicit lifecycle and native dependency boundary. Theme application, control helpers and editor orchestration remain host responsibilities unless a separate UI library is deliberately introduced.

## Stage 5: future integration is outside this scope

The main application remains unchanged throughout the current work. Do not add a project reference, replace a call, introduce a VB adapter, remove VB logic or alter a form/designer/resource. If the user later explicitly requests integration, plan it separately with copied K1/K2 fixtures, editor lifecycle checks and build/deployment verification. A library port alone is not permission to integrate it.

## Required checks for each slice

1. Capture the original behavior before editing. Use copied or synthetic fixtures, with hashes/expected bytes where appropriate. Compare VB and C# results, exceptions and side effects; report deliberate fixes separately.
2. Review VB-specific array upper bounds, `Nothing`, `ByRef`, default/indexed properties, late conversion, string comparison, integer division, checked arithmetic, signedness and event wiring.
3. Exercise empty/truncated input, unknown data, signed limits, duplicate records and invalid offsets as relevant. Test stream ownership, repeated use and failure cleanup. Test both game variants where behavior differs.
4. Rebuild the complete solution using full-framework Visual Studio MSBuild with `Configuration=Debug;Platform=x86`; use Release/x86 for changes affecting configuration/deployment. SDK `dotnet build` is not the acceptance path for the current resource pipeline.
5. Run the focused automated tests and required manual editor/designer/process checks. No new warnings. Explicitly label missing real-game fixtures and manual checks; do not represent simulated game contexts as integration coverage.
6. Update this ledger, the library guide and the source inventory. Leave application documentation and directory guides unchanged. Record what moved, what remains in VB, compatibility decisions, evidence and the next bounded slice. Stop at the stage boundary with a buildable standalone library and the application untouched.

## Commands

From the solution directory, using the local Visual Studio MSBuild installation:

```powershell
& '<Visual Studio>\MSBuild\Current\Bin\MSBuild.exe' kotor_tool.sln /t:Rebuild /p:Configuration=Debug /p:Platform=x86
& .\ktlib\tests\Run-SsfTests.ps1
& .\ktlib\tests\Run-RimTests.ps1
& .\ktlib\tests\Run-BiffTests.ps1
& .\ktlib\tests\Run-KeyTests.ps1
& .\ktlib\tests\Run-ErfTests.ps1
& .\ktlib\tests\Run-TwoDaTests.ps1
```

The test script also accepts `-LegacySource <path-to-original-clsSSF.vb>` to run the parity suite against a saved reference. By default it compiles the unchanged application VB file into a separate temporary host with isolated substitutes, avoiding registry/settings/game access. The originals and temporary binaries are test evidence, not production dependencies.

## Recorded validation — 2026-11-16

The standalone SSF suite passes 4,978 checks against expected bytes and the unchanged VB reference. The temporary host does not modify or run the main application. Debug and Release library builds pass with no warnings or errors. Application integration changes attempted before the user clarified the boundary were undone; the original VB source and application reference graph are retained. Final full-framework Debug/x86 and Release/x86 solution rebuilds in the restored, unintegrated state both pass: 0 errors and 187 existing warnings. No ktlib project reference or copied ktlib assembly remains in the application.
