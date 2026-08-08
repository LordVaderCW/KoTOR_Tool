# Dialog and Talk-Table System

This directory covers two related formats:

- `clsDialogTlk` reads `dialog.tlk`, returning localized text, sound ResRefs, lengths and batches of talk entries.
- `clsDLG` builds a conversation tree over GFF dialog data. `DLGConvListNode` represents entry/reply nodes and link relationships; the remaining types carry localized-string/list data.

## Operating heuristics

- A dialog line can use an external TLK StrRef or embedded `CExoLocString` content. Preserve that distinction when editing.
- DLG conversation flow uses separate entry/reply lists plus links; displayed tree nesting is a projection, not the storage model.
- Linked nodes may share underlying conversation targets. Copy/delete operations must distinguish a link from an owned node and update linked text/references.
- Game-version context flows into the inherited GFF structure and string/resource lookup.

## Change and verification

Test cycles/shared links, empty conversations, embedded strings, invalid/missing StrRefs, multiple languages, animations, scripts and delay/quest metadata. Verify both tree behavior and serialized GFF lists; a visually correct tree can still contain broken indices.
