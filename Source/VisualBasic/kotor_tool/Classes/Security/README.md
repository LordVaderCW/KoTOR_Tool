# KEY and Legacy Security

`clsChitinKey` maps ResRef/type to packed BIFF IDs and performs heuristic install validation. `Crypt` is fixed-key DES obfuscation, not modern security; `utilFileValidator` is a legacy keyed hash. Preserve KEY bit widths, allow legitimate modified/localized installs, and never reuse these primitives for new secrets/authenticity.
