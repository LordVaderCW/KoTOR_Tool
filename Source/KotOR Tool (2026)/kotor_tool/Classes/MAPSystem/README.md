# Map Information System

`clsMapInfoCreator` builds and writes the `MapInfo.bfd` dataset used to associate modules with map metadata. `MapInfo`, nested `Map`, and `MyMapInfoSurrogate` provide the serializable object model/surrogate support.

The creator derives data from game resources and module naming conventions. Preserve KoTOR I/II distinctions, module identity and serialization compatibility. Binary/runtime serialization is version-sensitive and unsafe for untrusted input; do not deserialize arbitrary downloaded BFD files. Verify generated data against several interior/exterior modules, missing map resources and the existing `MapInfo.bfd` consumer.
