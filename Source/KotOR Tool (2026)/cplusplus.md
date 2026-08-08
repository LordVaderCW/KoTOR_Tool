# C++ Status and Native Boundary

There are no C, C++ or C++/CLI source files/projects in this solution.

The current native boundary is binary-only: `fmodex.dll` is loaded through the managed `FMODCL.dll` wrapper, while `GFFEditor.exe`, `nwnnsscomp.exe` and plugin executables run as child processes. Keep the application x86 because these components have not been proven architecture-neutral.

## When C++ is justified

C++ is appropriate only for a measured need such as replacing an unavailable native audio dependency, implementing a high-throughput codec after profiling, or wrapping a required native library. Ordinary parser modernization is safer in a managed library because the application, UI and existing data model are managed.

## Native integration rules

- Prefer a narrow C ABI with explicit buffer lengths and ownership rules, or a separately versioned command-line tool.
- Never pass WinForms objects or VB `Object` values across the native boundary.
- Define packing, endianness, integer widths and calling convention explicitly.
- Ship architecture-matched binaries and fail with a clear dependency diagnostic.
- Validate all archive offsets and lengths before native memory access.
- Add fixture/fuzz tests around the managed/native boundary and document third-party licensing.

C++/CLI would tie the bridge to the .NET Framework/MSVC toolchain and should be used only when P/Invoke or a process boundary cannot express the API cleanly.
