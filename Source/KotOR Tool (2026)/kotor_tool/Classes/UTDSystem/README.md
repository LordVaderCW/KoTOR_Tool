<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/UTDSystem/README.md
# UTD Door System

`clsUTD` is a thin `clsGFF` specialization for door templates. The operational schema is implemented by `frmUTD_Editor` through shared GFF path helpers.

Keep the wrapper thin; place reusable schema logic in typed services rather than adding more control coupling. Test lock/key, faction, conversation, scripts, appearance/animation and localized name/description fields in both games. Preserve fields the editor does not expose.
=======
# UTD System

Thin GFF specialization for doors; schema lives in `frmUTD_Editor`. Test lock/key, faction, conversation, scripts, appearance and localized text across both games while preserving unexposed fields.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/UTDSystem/README.md
