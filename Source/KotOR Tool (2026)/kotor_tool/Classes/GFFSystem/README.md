# GFF System

`clsGFF` is the central structured-resource engine. It parses GFF V3.2 headers/tables, projects structs, fields, lists and complex values into a tree, supports path-based mutation, and writes a new GFF. Supporting classes represent field/struct table entries, localized strings, lists, orientation/vector types and raw void data.

## Operating heuristics

- GFF stores fields by type across multiple tables. Field labels, struct indices, list indices and field-data offsets must remain mutually consistent.
- `GFFField` includes primitive integers/floats, strings/ResRefs, localized strings, void bytes, structs/lists and vector/orientation values (`GFFType17`/`GFFType16`). Preserve widths and signedness.
- Node paths are used by specialized editors. A path is effectively schema API; changing labels/list structure breaks many forms.
- `clsGFF` adds KoTOR Tool metadata fields and can resolve `dialog.tlk`/2DA values. It also writes values directly to WinForms controls, so it is not a pure codec.
- The `KotorVersionIndex` influences string table and schema behavior. `-1` triggers detection/prompt paths in the UI.

## Change and verification

Create fixtures for every field type, nested structs/lists, empty lists, multiple localized substrings, unknown fields and malformed offsets. Round-trip semantically and confirm untouched fields survive. Test specialized editors after any path/mutation change. Keep raw parsing independent of display-string lookup in new APIs so headless tests can grow around the codec.
