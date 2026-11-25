# Binary 2DA and base-item helpers — iteration 3.4

Sources reviewed: `cls2DA`, `clsBaseItems2DA`, the data-only `TreeBaseItem`, and `frm2DAEditor.Write2daV2bFile`. The original GFF/editor callers use row indexes and named columns to populate controls. This slice provides data operations only; no editor, TLK parser, settings, game paths or application references move into ktlib.

`TwoDaCodec.Read(byte[])` snapshots the input. It starts column parsing at byte 9, reads tab-separated columns ending in tab/NUL, positive Int32 row count, tab-terminated row labels, UInt16 cell offsets plus a size word, then ASCII NUL-terminated strings. Empty strings become `****`. As in VB, the signature and stored string-pool size are not validated; offsets are checked against the actual input. `CopyOriginalBytes()` preserves the complete original buffer, including header/size word, unused strings and trailing data.

`TwoDaTable` has immutable columns, row labels and cells. Cell coordinates are uniformly zero-based and do not include the row-label column. `GetRow` returns every cell; `GetRowWithLabel` explicitly prepends the label. Named lookups are case-sensitive and select the first duplicate. Missing names throw KeyNotFoundException; invalid indexes throw ArgumentOutOfRangeException. `FindRow/FindColumn` return -1 on misses. Newly constructed tables snapshot arrays, require matching dimensions and reject tab/NUL in names or NUL in cells. Null/empty cells normalize to `****`. Tables constructed from values have no original-byte snapshot.

`TwoDaCodec.Write(table)` returns new binary V2.b bytes with first-occurrence string interning, ASCII replacement, unsigned 16-bit offsets and an explicit pool-size word. `****` serializes as an empty string. Pool size including terminators must fit 65535 bytes. Labels/columns preserve ordering and duplicate identity; no sorting or automatic row renumbering occurs. Canonical writing is separate from exact original-byte copying and does not retain unused input strings or arbitrary trailing bytes.

## Direct helpers

`BaseItemCatalog.Create(table, Func<int,string>)` returns immutable `BaseItemInfo` records carrying row index, item type, label, resolved name and slots. Nonnumeric `name` cells produce `(label)` as in VB. `WriteNamesAndTypes` accepts a TextWriter and uses `****` for those nonnumeric names, matching the original print routine; the caller owns the writer. Missing columns are treated as null by this helper, matching the VB named-column overload.

Exact VB numeric compatibility is retained through the .NET Framework Microsoft.VisualBasic runtime (`Information.IsNumeric` and `IntegerType.FromObject`): this preserves culture handling, hex/octal recognition, rounding and overflow. The C# library now references that framework assembly, not the VB application. TLK text is supplied only through a callback; no TLK file is loaded. The output helper resolves the complete item list before writing, so a conversion/lookup failure produces no partial output rather than the VB routine's possible partial console output.

## Explicit corrections and boundaries

- Original row-name overloads add one to the found row; C# selects the actual matching row. Original `GetRow` returns the label and all but the final cell, leaving its last array element null; the two C# row methods are explicit and complete.
- Empty-row/empty-column tables are supported; the legacy scanner mishandles zero rows and an empty column block. New malformed-input failures are InvalidDataException for missing delimiters, truncated offsets, out-of-range strings and unterminated cells. The UInt32-to-positive-Int32 row overflow remains OverflowException.
- The UI writer has a spare offset slot because VB array bounds are inclusive. It computes the final pool size in that slot but never writes the size word to the reserved file position. C# writes all offsets and the size word directly. Pool order is deterministic instead of Hashtable enumeration order; offsets use the full UInt16 range instead of the legacy CShort limit. No byte-parity claim is made for the broken UI save routine, and that routine remains unchanged.
- Writing uses encoded byte lengths, preventing non-ASCII replacement from shifting offsets. Input signatures are retained only by exact-copy API; canonical output always uses `2DA V2.b\n`.

Tests compare ordinary reads/base-item projections with unchanged VB in an isolated host and read C# output with the original reader. Independent byte checks cover offsets, size word and missing markers; explicit tests cover corrected row behavior, zero dimensions, pool boundaries, malformed input and ownership. No UI writer is launched, and no real game/TLK data is accessed. Real K1/K2 editor coverage remains a future integration requirement.

Recorded verification: 5,419 2DA/base-item checks pass. Both final Debug/x86 and Release/x86 full-framework builds pass with 0 errors and the existing 187 warnings; isolated original VB sources retain five BC42104 warnings. All 370 application/solution files are unchanged.
