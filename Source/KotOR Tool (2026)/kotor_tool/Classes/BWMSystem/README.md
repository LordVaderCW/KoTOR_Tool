# BWM / Walkmesh System

`clsBWM` models binary walkmeshes and can parse ASCII walkmesh input, write binary BWM data and emit an ASCII representation. Nested value types describe vertices, faces, unknown integer pairs and AABB nodes.

## Operating heuristics

- Walkmesh meaning is encoded by ordered vertex/face arrays plus offset/count tables and an AABB tree.
- Geometry indices are positional contracts. Reordering vertices or faces requires updating every dependent index/node.
- Binary write layout and ASCII parse/write form a useful differential check, but an ASCII round trip may not preserve unknown binary padding or ordering.
- `Application.ProductVersion` is written in the ASCII header and is informational, not part of geometry.

## Change and verification

Use little-endian fixed-width values, validate all counts/indices, reject non-finite coordinates, and preserve unknown values. Test WOK/PWK/DWK variants from both games, empty/minimal geometry, AABB traversal and binary-to-ASCII-to-binary semantic equivalence.
