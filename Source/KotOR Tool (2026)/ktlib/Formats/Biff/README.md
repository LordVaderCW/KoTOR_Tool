# BIFF variable-resource reader — iteration 3.2

Read-only counterparts of `BIFFArchive`, `BIFFVarRsrcEntryInfo` and the data-only `BIFFVarRsrcEntry`. The latter becomes a returned byte array rather than a wrapper. Despite its folder/name, `BIFFEntry` reads a KEY file-table entry and normalizes its filename; it is transposed alongside this reader in [Formats/Key](../Key/README.md), following the user's request to do both together. No application source, writer, native playback or UI integration is changed. KEY mapping remains a separate library responsibility.

## Original behavior and callers

The VB constructor reads four UTF-8 characters each for signature/version, then three signed little-endian Int32 values: variable count, fixed count and variable-table offset. Reading begins at the supplied stream's current position. Table and payload offsets are absolute stream positions. Signature/version are read, not validated. Fixed-resource parsing is not implemented.

Variable records contain four signed Int32 values: resource ID, offset, size and resource type. `getBIFFResource(offset)` uses its argument as a **table index**, not a lookup by stored ID. IDs/types can be negative and are retained without normalization. `frmMain`, GFF/editor callers and cached template archives handle game selection, paths and KEY-ID splitting outside this reader; sound callers consume resource offset/size metadata. Static VB helpers open read-only files with `FileShare.ReadWrite` and a 200,000-byte buffer.

## C# boundary

`BiffArchive(Stream, bool leaveOpen = true)` borrows a readable, seekable stream by default; successful construction with `leaveOpen: false` transfers disposal responsibility to the archive. Construction failure always leaves a supplied stream open. `Dispose()` is idempotent, and instance read methods throw `ObjectDisposedException` afterward. Metadata properties remain available. Calls change stream position, as in VB; the reader is not thread-safe and callers must not access the stream concurrently.

`GetResourceInfo(index)` returns immutable `BiffResourceInfo`. `GetResourceInfoList()` reads metadata in table order. `GetResource(index)` returns a new byte array. `ReadResource(path, index)` and `ReadResourceInfoList(path)` manage their own file handles on success and failure with the same share/buffer settings as VB. There is no default uninitialized constructor or application dependency.

Signature, version, variable/fixed counts and table offset are exposed. Uninterpreted ID/type values remain signed. Header padding, fixed-resource data and trailing bytes are not rewritten or normalized: the reader never writes its stream. It does not promise an archive serialization API or fixed-resource support.

## Explicit safety differences

Negative variable counts/table offsets and tables outside the stream fail with `InvalidDataException` before list allocation. Index bounds are enforced. Table-position arithmetic uses `long`, avoiding VB's Int32 multiplication overflow. Table ranges are rechecked when reading metadata because the borrowed stream can change.

Offset/size values remain signed and visible in metadata, including malformed negatives. Extraction rejects negative/out-of-range payload ranges with `InvalidDataException`. A stream that becomes short during the actual read throws `EndOfStreamException` rather than returning partial bytes as VB `ReadBytes` can. Header truncation also throws `EndOfStreamException`. Valid overlapping payloads and zero-length payloads at EOF remain allowed. Fixed count is retained verbatim and not interpreted or validated as a table.

This iteration deliberately retains UTF-8 character-based header reading rather than silently changing it to byte-based FourCC validation. That difference needs a separate format-policy change if desired.

## Verification

Run `../../tests/Run-BiffTests.ps1`. The script compiles the three unchanged VB source files into a temporary reference assembly, then compares instance and static operations against deterministic synthetic files. Tests cover empty/multiple entries, signed extremes, duplicates, non-index IDs, reordered reads, zero/overlapping payloads, UTF-8 headers, nonzero header positions, bounds failures, short-read streams, truncated input and disposal/handle release. Inputs are temporary synthetic fixtures only.

The parser has no game-version branch; shared-format parity does not establish real K1/K2 fixture or editor coverage. Both-game copied fixtures remain a future integration requirement. KEY mapping is implemented in the adjacent KEY namespace and tested together with this reader. Fixed-resource support remains outside this slice.

Validation: 3,406 BIFF assertions pass against the unchanged VB implementation and synthetic fixtures. See the KEY tests for the combined extraction path.
