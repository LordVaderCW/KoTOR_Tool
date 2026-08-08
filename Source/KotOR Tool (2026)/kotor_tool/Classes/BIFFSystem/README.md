# BIFF System

`BIFFArchive` reads BIFF header counts/offsets, locates variable-resource table entries and returns resource bytes. `BIFFEntry` represents a BIFF listed by `chitin.key`; `BIFFVarRsrcEntry` and `BIFFVarRsrcEntryInfo` carry resource ID, offset, size and type data.

## Operating heuristics

- KEY lookup happens first. The packed resource ID identifies the BIFF and resource entry; `frmMain`/`clsChitinKey` coordinate that mapping.
- `BIFFArchive` retains a `FileStream` and seeks for each lookup. The caller must keep the stream alive for the archive's use and close it at the correct workflow boundary.
- Extraction reads exactly `FileSize` bytes at `FileOffset`; it does not decode content.
- BIFF support is read/extract oriented. Writes belong in a separate, explicitly tested builder rather than being added to lookup code casually.

## Change and verification

Validate table offsets, counts, entry multiplication and `offset + size` against stream length before allocating or reading. Test multiple resources from the same retained stream, invalid IDs, truncated headers and large files. Never write into an installed game's BIFF during a parser test.
