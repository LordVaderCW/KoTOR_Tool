<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/UTCSystem/README.md
# UTC Creature System

`clsUTC` specializes `clsGFF` for creature templates (`UTC`). It supports stream/byte construction, creation of an empty shell and access to struct arrays used by the creature editor.

Most UTC schema knowledge lives in `frmUTC_Editor`: stats, classes, feats, skills, inventory, scripts, appearance and localized names are GFF paths/lists. Preserve unknown fields and KoTOR I/II differences when creating shells or editing lists. Test minimal and complex creatures, multiclass/feat lists, inventory/equipment, embedded/TLK names and read-write-reopen behavior.
=======
# UTC System

`clsUTC` specializes GFF for creature templates and empty shells; `frmUTC_Editor` contains schema for stats/classes/feats/skills/inventory/scripts/appearance. Preserve unknown fields and game differences; test minimal/complex creatures and semantic reopen after save.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/UTCSystem/README.md
