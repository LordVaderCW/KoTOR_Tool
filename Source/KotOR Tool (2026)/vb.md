# VB.NET Implementation Guide

VB.NET is the only compiled source language in the current solution.

## Compiler contract

- Project defaults: `Option Explicit On`, `Option Strict Off`, `Option Infer Off`, `Option Compare Binary`.
- Many recovered files restate `Option Strict Off`/`Option Explicit On`; one file enables strict mode. Files without directives inherit the project defaults.
- The project has an empty `RootNamespace`; source files explicitly declare `Namespace kotor_tool`.
- `KT_Launch.Main` is the explicit startup object, so VB's application framework is not the entry point.
- All configurations target x86 even when the solution platform says `Any CPU`.

## Recovered-code heuristics

- Token/RVA comments and `Microsoft.VisualBasic.CompilerServices` calls are decompiler provenance, not design intent.
- `StringType.StrCmp`, `ObjectType`, `BooleanType`, late-bound `Object` values and uninitialized locals are common. Do not mechanically “clean” them without tests; implicit VB conversion and default-value behavior may be relied upon.
- Prefer adding explicit types and conversions in new code. Tightening `Option Strict` is a per-file migration that must resolve every late-bound call and numeric conversion deliberately.
- Arrays and indices frequently reflect binary on-disk offsets. Preserve signedness, field width, endianness and overflow behavior.
- Most parsers own or retain streams differently. Check constructor behavior before adding `Using`; do not close a stream still held by an archive object.

## WinForms pattern

Each form normally has:

- `frmName.vb` for constructors, event handlers and behavior;
- `frmName.Designer.vb` for generated fields and `InitializeComponent`;
- `frmName.resx` for images, icons and other serialized resources.

Keep partial-class names and `DependentUpon` metadata synchronized. Use the designer for layout edits where possible. Theme application happens after component initialization and can recursively restyle standard/custom controls.

## Data-code pattern

- Binary readers/writers implement KEY/BIFF, RIM, ERF, GFF, TLK, SSF and BWM layouts.
- `clsGFF` exposes path-based node operations plus WinForms control-binding helpers.
- Type-specific GFF classes primarily select file type/game behavior; type-specific forms contain most schema knowledge.
- `frmMain.GetIDForRsrcType` and `GetRsrcTypeForID` are central compatibility tables. Update both directions together.

## Safe change pattern

1. Identify the byte/file/UI boundary and capture a representative fixture.
2. Add validation around new input without changing valid legacy output.
3. Keep game-version branches explicit.
4. Build with full Visual Studio MSBuild for Debug and Release x86.
5. Round-trip changed formats and compare semantic fields plus unaffected bytes.
6. Open affected forms in the designer and at runtime.
7. Do not increase the warning baseline.

## Modernization priorities

High-value seams are extracting codecs from forms, replacing global caches with injected services, introducing typed resource identifiers, adding fixture tests, and then enabling strict typing one subsystem at a time. A wholesale syntax conversion before those seams exist would preserve the current coupling in another language.
