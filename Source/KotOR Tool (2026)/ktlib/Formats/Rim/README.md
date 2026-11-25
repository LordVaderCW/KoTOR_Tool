# RIM read/extract transposition contract

Scope: one standalone slice of stage 3. Reference sources are the unchanged `clsRIM.vb` and `RIMKeyEntry.vb`. No writer, resource-extension registry, tree node, file-path policy, game discovery or application integration is included.

## Source findings

The VB constructor takes a complete byte array, reads a count at offset 12 and table offset at 16, then parses 32-byte entries. Names are ASCII, terminated by the first zero within 16 bytes (or use all 16 bytes). Each entry's type is read from bytes 16–17; its property called resource ID comes from bytes 18–19. Bytes 20–23 are ignored. Offset and length come from bytes 24–27 and 28–31. These are observations of the existing code, not a new interpretation of the file specification.

VB uses checked conversions: both 16-bit values must fit a positive `Short` (0–32767) and 32-bit counts/offsets/lengths must fit a positive `Integer`. Preserve these overflow boundaries in this compatibility implementation. Unknown types within the accepted range remain extractable; larger types still throw `OverflowException`, as in VB. Expanding numeric support or changing the resource-ID location requires a separate format-correction stage.

`frmMain` uses the reader to list entries, search module payloads and extract resources. `KotorTreeNode` consumes name, type and the legacy ID. Extension lookup through `frmMain.GetRsrcTypeForID` belongs to presentation and is omitted from the new entry type. The parser itself has no game-version branch; game path selection is in callers.

## Standalone API

- `RimArchive(byte[])` exposes `EntryCount`, `KeyListOffset` and an ordered, read-only collection of immutable `RimEntry` metadata.
- `RimEntry.LegacyResourceId` deliberately names the old byte-18 interpretation. Names, duplicate entries, numeric types and indexes retain their original order and values.
- `GetResource(index)` returns a new byte array. Empty resources are valid, including at end of input. Bounds-valid overlapping regions remain accepted; no normalization is performed.
- `CopyArchiveBytes()` returns an exact copy of the original bytes, retaining ignored header fields, entry bytes, padding and trailing data. This is byte preservation, not archive writing or field editing.
- Header signature/version remain uninterpreted, matching VB tolerance. No file handles, UI objects or native dependencies are acquired.

## Deliberate boundary differences

The C# object owns a snapshot of the input rather than VB's mutable borrowed array. Returned arrays are independent copies. Metadata cannot be edited after parsing. These choices prevent later caller mutation from invalidating checked ranges.

The constructor rejects short headers, out-of-range tables and out-of-range payloads with `InvalidDataException` before allocating an entry list or extracting a payload. VB can instead fail with incidental array/copy exceptions, or defer failure until extraction. Range arithmetic uses `long` to avoid overflow. Counts and fields outside VB's numeric range still throw `OverflowException`. Null input throws `ArgumentNullException`; invalid entry indexes throw `ArgumentOutOfRangeException`.

An empty table must have an offset within the input in C#. VB accepts arbitrary offsets for zero entries; this is part of the explicit bounds-checking difference. Valid archives are compared against the VB implementation; malformed behavior is tested and documented separately.

## Tests and limits

`../../tests/Run-RimTests.ps1` compiles the two original VB files in a temporary host with only an extension-lookup stub. It compares metadata and extracted bytes for deterministic synthetic archives, including duplicate names, all 16 name bytes, embedded NULs, non-ASCII replacement, unknown types, zero lengths, padding and ignored bytes. Separate tests cover numeric overflow, truncated tables/payloads, impossible counts, index bounds and mutation isolation.

No game files or UI are accessed. The shared reader has no K1/K2 branches; synthetic parity does not establish real-game integration coverage. Use copied fixtures from both games before any future application integration.
