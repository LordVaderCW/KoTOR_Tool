# RIM Archive System

`clsRIM` parses an in-memory RIM archive into `RIMKeyEntry` records and extracts bytes by entry index. Each entry carries resource name/type, resource ID, offset, length and display extension.

RIM is currently a read/extract path. The constructor receives the complete byte array, so validate header/table counts and every `offset + length` before slicing. Resource type display depends on `frmMain.GetRsrcTypeForID`; unknown numeric types must remain extractable even when no extension is known. Test truncated tables, duplicate ResRefs, unknown types, zero-length resources and both games' module RIMs.
