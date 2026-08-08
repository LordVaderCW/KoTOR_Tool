# Row Filter System

`RowFilter` combines `RowFilterPart` objects into a filter expression for grid/data-table views. Each part tracks native/display column names, operator, text, concatenation and datatype.

Filter strings are executable `DataView`-style expressions, so escape quotes, wildcard characters and column names rather than concatenating raw user text. Preserve datatype-aware formatting and explicit AND/OR grouping. Test empty filters, numeric/string/date values, embedded quotes, nulls and multiple clauses. Several fallback locals currently produce compiler warnings and deserve focused tests before cleanup.
