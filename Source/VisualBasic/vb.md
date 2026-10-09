# VB.NET Guide

VB.NET is the only compiled language: 223 files under explicit `Namespace kotor_tool`, empty project `RootNamespace`, and `KT_Launch.Main` startup. Defaults are `Option Explicit On`, `Option Strict Off`, `Option Infer Off`, `Option Compare Binary`; every configuration targets x86.

Token/RVA comments, compiler helpers, late-bound `Object` and possible uninitialized locals are decompiler artifacts. Do not mechanically rewrite them. New code should use explicit conversions, binary bounds and clear resource ownership.

Keep WinForms code-behind, `.Designer.vb`, `.resx` and `DependentUpon` aligned. Codecs may retain streams or depend on `frmMain`, so check ownership before adding `Using`. Safe work captures fixtures, preserves game/byte semantics, builds full-framework Debug/Release x86, round-trips data and smoke-tests designer/runtime behavior.
