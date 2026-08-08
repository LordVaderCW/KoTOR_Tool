# C# Status and Migration Guide

There are no `.cs` files or C# projects in this solution. C# is a possible migration language, not a current dependency.

## Recommended migration boundary

Start with isolated codecs and value objects, not forms. A C# class library targeting .NET Framework 4.6.2 can be referenced by the VB WinForms executable, allowing incremental replacement while keeping the current UI and runtime dependencies stable.

Good early candidates are 2DA, RIM, BIFF entry/value types, SSF and pure resource-type mapping. GFF is valuable but higher risk because it combines parsing, mutation, string-table lookup and WinForms binding. `frmMain` and the module editor should be late-stage work because they are global orchestration hubs.

## Translation hazards

- VB with `Option Strict Off` performs implicit numeric, string, enum and `Object` conversions that C# will reject or interpret differently.
- VB array upper bounds (`New T(n)` creates `n + 1` elements) must become explicit C# lengths.
- Default properties, late binding, `Nothing`, `ByRef`, integer division, checked overflow and `Microsoft.VisualBasic` helper semantics need targeted review.
- Event wiring may be in `Handles`, `AddHandler`, or designer-generated code.
- Signed/unsigned conversions are format-significant.
- WinForms `.resx` and designer metadata should remain owned by one language/project during each migration step.

## Interop rules

- Keep public boundary types CLS-friendly where possible: `Stream`, `byte[]`, immutable records/DTOs and explicit enums.
- Do not expose WinForms controls from new codec APIs.
- Preserve the `kotor_tool` namespace or use explicit imports/type forwarding during transition.
- Test VB caller behavior before deleting the old implementation.
- Retain x86 and the same deployment layout until FMOD and external tools are addressed independently.

## Completion criteria for a migrated subsystem

The C# replacement must parse existing fixtures, reproduce valid output, preserve unknown fields, handle KoTOR I/II branches, pass malformed-input checks, and build through the solution's full-framework MSBuild path. Only then should the VB implementation be removed.
