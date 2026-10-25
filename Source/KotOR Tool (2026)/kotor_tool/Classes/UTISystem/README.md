<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/UTISystem/README.md
# UTI Item System

`clsUTI` is the GFF specialization for item templates. `frmUTI_Editor` and the inventory/item-property forms handle base item, model/variation, costs, charges, stack size, upgrade state, descriptions and property lists.

Item property encoding depends on 2DA indices and parameter/subtype tables. Preserve numeric IDs even when a current 2DA lacks a display value. Test KoTOR I/II baseitems and item-property tables, empty/multiple properties, upgradeable items, stack/charges and localized descriptions. Round-trip unknown property fields.
=======
# UTI System

Thin GFF specialization for items. Item properties depend on 2DA numeric IDs; preserve unresolved IDs, unknown property fields and localized text. Test both games, empty/multiple properties, upgrades, charges and stacks.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/UTISystem/README.md
