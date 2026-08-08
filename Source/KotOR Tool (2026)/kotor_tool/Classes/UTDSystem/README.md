# UTD Door System

`clsUTD` is a thin `clsGFF` specialization for door templates. The operational schema is implemented by `frmUTD_Editor` through shared GFF path helpers.

Keep the wrapper thin; place reusable schema logic in typed services rather than adding more control coupling. Test lock/key, faction, conversation, scripts, appearance/animation and localized name/description fields in both games. Preserve fields the editor does not expose.
