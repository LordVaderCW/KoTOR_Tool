# UTC Creature System

`clsUTC` specializes `clsGFF` for creature templates (`UTC`). It supports stream/byte construction, creation of an empty shell and access to struct arrays used by the creature editor.

Most UTC schema knowledge lives in `frmUTC_Editor`: stats, classes, feats, skills, inventory, scripts, appearance and localized names are GFF paths/lists. Preserve unknown fields and KoTOR I/II differences when creating shells or editing lists. Test minimal and complex creatures, multiclass/feat lists, inventory/equipment, embedded/TLK names and read-write-reopen behavior.
