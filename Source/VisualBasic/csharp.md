# C# Migration Guide

Treya has no C# source. Start any migration with a .NET Framework 4.6.2 library for isolated codecs/value types (2DA, RIM, BIFF, SSF, image helpers). GFF is higher risk because it combines parsing, mutation and UI/TLK/2DA binding; `frmMain` and module/model/plugin orchestration should move last.

Review VB array upper bounds, implicit/late conversion, `Nothing`, `ByRef`, default properties, events, integer division/overflow and signedness. Use CLS-friendly stream/byte-array/DTO boundaries and remove VB only after cross-language fixtures prove equivalence.
