# 2DA System

`cls2DA` parses binary KoTOR 2DA data into column names, row labels and cell offsets, then exposes rows through a `DataTable`-oriented API. `clsBaseItems2DA` specializes it to derive item names/types from `baseitems.2da`.

## Operating heuristics

- Input is an in-memory byte array obtained most often from a BIFF resource.
- Cell values are decoded from indexed offsets; missing/default markers must remain distinguishable from an empty string.
- Column names are compatibility keys used throughout editors. Treat spelling and case behavior as data contracts.
- The GFF helpers use 2DA values and `dialog.tlk` together to populate combo boxes and resolve StrRefs.

## Change and verification

Bounds-check row, column and string offsets before decoding. Preserve row-label semantics and column ordering. Test with KoTOR I and II tables, default markers, empty cells, and the exact tables consumed by a changed editor. Existing compiler warnings in fallback return paths are recovery debt, not permission to return `Nothing` silently in new code.
