<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/MAPSystem/README.md
# Map Information System

`clsMapInfoCreator` builds and writes the `MapInfo.bfd` dataset used to associate modules with map metadata. `MapInfo`, nested `Map`, and `MyMapInfoSurrogate` provide the serializable object model/surrogate support.

The creator derives data from game resources and module naming conventions. Preserve KoTOR I/II distinctions, module identity and serialization compatibility. Binary/runtime serialization is version-sensitive and unsafe for untrusted input; do not deserialize arbitrary downloaded BFD files. Verify generated data against several interior/exterior modules, missing map resources and the existing `MapInfo.bfd` consumer.
=======
# Map System

`clsMapInfoCreator` builds `MapInfo.bfd`; map models and a serialization surrogate preserve module/map metadata. Keep game/module identity stable and do not deserialize untrusted binary-serialized data. Verify several interior/exterior modules and missing map resources.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/MAPSystem/README.md
