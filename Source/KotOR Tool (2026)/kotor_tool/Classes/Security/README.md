<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/Security/README.md
# KEY Index and Legacy Security Helpers

`clsChitinKey` parses `chitin.key`, building KEY entries, BIFF metadata and lookup hashes. It maps a ResRef/resource type to a packed resource ID and can validate known game BIFF layouts. `KeyEntry` is the lookup record.

`Crypt` is legacy reversible DES obfuscation with a hard-coded key/IV. It is not suitable for passwords, secrets or authenticity. `utilFileValidator` (under `UtilitySystem`) performs keyed hashes for legacy updater validation; its algorithm selection/defaults should not be treated as a modern signature scheme.

## Heuristics

- KEY/BIFF identifiers and bit packing are format contracts; preserve widths and game-version rules.
- Hash lookups must retain type as part of identity.
- “Official file” size checks are heuristics and can reject localized or legitimately modified installs; keep user messaging non-destructive.
- Never reuse `Crypt` for new sensitive data. Use authenticated, versioned cryptography and OS-protected key storage for any new security feature.

Test clean, modified, localized and truncated KEY files plus missing BIFFs, unknown resource types and duplicate names.
=======
# KEY and Legacy Security

`clsChitinKey` maps ResRef/type to packed BIFF IDs and performs heuristic install validation. `Crypt` is fixed-key DES obfuscation, not modern security; `utilFileValidator` is a legacy keyed hash. Preserve KEY bit widths, allow legitimate modified/localized installs, and never reuse these primitives for new secrets/authenticity.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/Security/README.md
