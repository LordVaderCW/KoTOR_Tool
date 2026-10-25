# C++ and Native Boundary

There is no C/C++ source project. Native behavior is binary/process based: FMOD Ex, GFFEditor, NWScript compiler, 7-Zip and MDLOps.

Use C++ only for a measured native need. Prefer a narrow C ABI with explicit ownership or a versioned process interface. Define packing/calling convention/endianness/architecture, never pass WinForms or late-bound objects across the boundary, and keep x86 until every native component is verified otherwise.
