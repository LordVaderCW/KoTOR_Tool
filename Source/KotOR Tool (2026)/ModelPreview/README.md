# MDL Viewer

Right-click an MDL resource in the tree, list, or details pane and choose **Open MDL Viewer**. Double-click and Enter retain the existing extraction workflow.

Only one preview window is owned by the main browser. While it is open, changing the focused tree/list/details selection (including Up/Down) automatically replaces its model without activating the viewer or moving keyboard focus. Selection changes are debounced for 180 ms; if conversion is already running, only the newest pending selection is retained. A request version prevents stale results from replacing a later selection. Closing the viewer cancels pending updates and an in-flight conversion cannot reopen it. Non-model selections leave the previous model visible. Conversion errors appear in the existing viewer instead of interrupting keyboard browsing with modal dialogs.

A blue animated loading bar replaces the loading-text banner during conversion and browser initialization; the HTML viewport continues the indicator while geometry and textures load. It hides after the first model render, on cancellation, or on failure. Progress is indeterminate because MDLOps does not report a usable percentage. Errors still appear as readable text. The native animation timer is disposed with its control; the HTML animation respects reduced-motion settings.

Replacement keeps the same WebView2 instance, reloads the local page with a fresh revision for both HTML and glTF requests, and updates the title/export source. Previous preview directories are removed after navigation, and remaining directories are removed on close. Each new model resets the camera and viewer controls. The embedded smoke test checks same window handle/browser process, fresh replacement data, updated title, and cleanup of both old and final directories.

`frmMain.ModelPreviewIntegration.vb` reads the selected archive entry, resolves its MDX in the same archive before falling back to that game's KEY, and runs the installed MDLOps decompile plugin with the corresponding K1/K2 game number. Each request gets a unique temporary directory. No game files are modified. The existing plugin runner supplies timeout and error handling; the main form guards against reentrant preview requests while it pumps messages.

`AsciiModel` reads ASCII geometry into a self-contained glTF 2.0 file. It preserves hierarchy/axis-angle transforms, converts Z-up to Y-up, expands face-specific UVs, flips V for glTF, and embeds decoded TPC textures as PNG. Textures are resolved in the selected archive/game KEY then the game's common texture packs. Missing textures produce a visible warning. Unknown ASCII fields are ignored without changing source bytes. Malformed indices, cycles, duplicate nodes, non-finite coordinates and unsafe resource names are rejected.

`PreviewController` hosts local HTML in WebView2 with a private virtual hostname; no localhost server or runtime CDN is used. The page offers turntable rotation, axis selection, pause, orbit, zoom, pan, wireframe and reset. Export writes a single portable `.gltf`. Dispose closes WebView2 and removes only that preview's temporary directory. The shared browser profile lives in LocalAppData/KotorTool/WebView2. A missing runtime displays an actionable error.

## Dependencies and limits

- Requires an installed/enabled MDLOps plugin. The supplied fixed WebView2 Runtime **157.0.4341.60 x86** is bundled in both Debug and Release; no machine-wide browser runtime installation is needed.
- WebView2 SDK **1.0.2903.40**, from the official NuGet package; managed net462 assemblies and the x86 loader are in `vendor`. License is included. This project targets .NET Framework 4.6.2/x86.
- Three.js **r128**, GLTFLoader and OrbitControls from the corresponding upstream GitHub tag, bundled under the included MIT license. These classic scripts avoid runtime module/package downloads.
- Local node-transform clips (position, axis-angle orientation and uniform scale) are previewable. Skeletal deformation, inherited supermodels, animation events, bezier controllers, TXI effects, lightmaps and smoothing groups are not reproduced. Skin/dangly/saber meshes show their stored static geometry. Walkmeshes and render-disabled nodes are omitted. TGA overrides and module-specific texture substitutions are not yet resolved. Texture alpha is treated as opaque because KotOR also uses alpha for TXI effects.
- Limits: 64 MB ASCII input, 10,000 nodes, one million rows per geometry array. Large conversion/texture decoding still runs on the UI thread after MDLOps completes.

## Verification

### Fixed runtime packaging

The user-supplied `Microsoft.WebView2.FixedVersionRuntime.157.0.4341.60.x86.cab` has SHA-256 `56AF6627C4D1F4431075BFB8AEA0E5D789F9AF0E0911EB8B9241CF6FBB3EFD98`. Its extracted `msedgewebview2.exe` has a valid Microsoft Corporation Authenticode signature. The full payload, including licenses, locales and support files, is preserved without binary modifications.

To provision a fresh checkout, create `ModelPreview/runtime` and run `expand.exe "<path-to-cab>" -F:* "ModelPreview/runtime"` from the solution directory. This produces `runtime/Microsoft.WebView2.FixedVersionRuntime.157.0.4341.60.x86/`. The large extracted payload is ignored by Git; preserve/provision it separately. The build fails with an explanatory error if it is absent. MSBuild copies all runtime files transitively to `WebView2Runtime/` beside the application executable in both configurations. Distribute that entire folder with the application, not just the EXE/DLLs.

`PreviewController` passes this application-relative folder explicitly to `CoreWebView2Environment.CreateAsync`. It does not depend on the Desktop CAB, an absolute developer path, registry runtime discovery or a system installation. Fixed runtimes do not automatically update; updating the packaged version is a release-maintenance responsibility.

Build with full Visual Studio MSBuild (x86), using the solution or `kotor_tool/kotor_tool.vbproj`. Explicit Debug/x86 and Release/x86 project configurations are mapped in the solution; reload an already-open solution after adding the project. Content and WebView2 dependencies copy transitively to the application output. `tests/ConverterTests.cs` compiles with `AsciiModel.cs`, `AsciiAnimations.cs`, System.Web.Extensions and System.Drawing; it checks geometry, hierarchy, invariant numeric parsing, UV orientation, embedding, source preservation, missing textures and malformed input. Test data is synthetic and isolated in temporary directories.

Validation on 2026-11-16: full-framework Debug/x86 and Release/x86 builds passed; 17 converter checks passed; Chromium loaded a textured glTF and exercised pause, axis, wireframe and reset without script errors. Copied K1 and K2 `w_blstrpstl_001` MDL/MDX fixtures were converted with upstream MDLOps 1.0.2 and each embedded one decoded texture. Copied `a_jedirobe_001` fixtures from both games converted; their referenced textures were absent and warnings were retained. Test-only downloads and game assets are ignored under `tests/output` and are not distributed.

The WebView2 host smoke test now passes with the bundled fixed runtime: a copied K2 textured model loads, pause/axis/wireframe/reset controls execute, screenshots capture, and repeated open/close removes preview temporary directories. Debug and Release x86 builds include the runtime. Browser rendering was also checked separately in installed Chrome. Manual acceptance also remains for right-click UI interaction, RIM/ERF resource selection, missing MDX/plugin, high DPI and full game-model visual likeness. `tests/GameModelSmoke.cs` takes game directory, copied-fixture output directory, MDLOps executable, game number and model resref; it never writes into a game directory. Its test executable needs the application DLLs and runtime config for the legacy image decoder.

Upstream references: https://github.com/ndixUR/mdlops ; https://github.com/mrdoob/three.js/tree/r128 ; https://learn.microsoft.com/en-us/microsoft-edge/webview2/concepts/working-with-local-content

## Designer and animation sidebar

Open `kotor_tool/WinForms/frmMain.ModelPreview.vb` with **View Designer** in Visual Studio. It now defines the standalone `frmModelPreview` form. Its standard `InitializeComponent`, named WinForms controls and layout live in `frmMain.ModelPreview.Designer.vb`, with a nested `frmMain.ModelPreview.resx`. All layout controls are standard framework types, so the designer does not need to load a custom x86 control. A blue panel marks the loading bar; the animated control and WebView2 are created only at runtime. The viewport toolbar itself remains HTML/CSS.

The parameterless constructor initializes only the editable form. The model constructor attaches the C# `PreviewController`, which manages browser lifecycle and animation messages. Browser context-menu/selection integration remains a partial of `frmMain` in `frmMain.ModelPreviewIntegration.vb`, nested under `frmMain.vb`. The form and integration therefore have separate design identities; opening the preview designer no longer opens an empty partial of the main form.
MDLOps now decompiles with animations included. `AsciiAnimations` reads both counted and `endlist` controller arrays, matches tracks to model nodes, converts rotations to glTF quaternions and retains declared duration. Only clips with supported matching tracks are listed. Selecting a clip starts playback and pauses the turntable; Play/Pause, Stop and Loop control Three.js AnimationMixer. Stop restores the rest pose. Replacement clears old clips and revision-checked WebView messages prevent stale state reaching the new model. Export includes the supported animations.

The parser/controller separation, named-node matching and sidebar playback structure draw on the MIT-licensed GhostRiggerGH source: `src/core/mdl/mdl_parser.py`, `native/GhostRigger.Core.Workflow/Python/src/core/animation/animation_engine.py`, and `native/GhostRigger.Core.Tools/Python/src/gui/panels/qt_animation_panel.py`. Its copyright/license is retained in `vendor/GhostRigger-LICENSE.txt`; its source tree was not modified. This implementation supports local transform tracks, not GhostRigger's full skinning or supermodel pipeline.

Validation on 2026-11-17: 25 converter checks passed, including both keyframe grammars and invalid times. Copied K1/K2 `plc_footlker` fixtures converted with textures and animation tracks. A WinForms DesignSurface loaded the actual VB preview form, found its sidebar controls and did not start WebView2. The embedded host test populated the clip list and exercised select, pause, stop, restart, model replacement and cleanup. Opening/saving the layout inside Visual Studio itself and high-DPI manual acceptance remain to be checked.
Animation playback regression (2026-11-17): zero-duration MDL clips are treated as poses, sampled at time zero and held paused. LoopRepeat on these clips produced a non-finite action time in the bundled Three.js runtime. Pose selection/replay now avoids looping and the sidebar labels them as poses. AnimationPlaybackSmoke.js runs the production viewport with copied fixtures, controls time deterministically and checks repeat selections, pause/resume, stop/rest-pose restoration, completed-clip replay and finite action clocks. Copied DOR_LMA07 (210 selections) and K1/K2 plc_footlker (180 each) passed; the door fixture reproduced the invalid clock before the fix. The embedded Release WebView2 smoke test also passed on the copied door fixture.

## Smoothing groups

Face smoothing masks generate area-weighted corner normals. Overlapping masks share normals across original vertex indices, including UV seams; zero/disjoint masks retain hard edges. Masks accept signed or unsigned 32-bit serialization. Positions are not welded, and degenerate faces retain finite fallback normals.

## Supermodels and Send to Max

Preview resolves each `setsupermodel` through the selected archive/game, stages copied MDL/MDX beside the preview, and converts it with the same game-specific MDLOps command. Animation-only supermodels may have no MDX. Local clip names override the whole inherited clip case-insensitively; nearer ancestors override farther ancestors. Tracks match the selected model's node names, with ancestor model-root names mapped onto the selected root. The clip list shows the source supermodel for inherited clips. Missing/malformed ancestors produce warnings while preserving usable clips; cycles and chains longer than 32 models stop safely. Selection changes and window closure invalidate pending conversion work.

Skin weights are normalized and expanded with the face corners into glTF joint/weight attributes. Inverse bind matrices derive from the selected model's rest hierarchy, retaining weighted skeletal deformation under inherited clips. No game files or NWMax importer code are modified.

The preview sidebar offers **Send to 3DS Max (2021)** and **Include animations**, checked by default. The request is bound to the displayed archive resource, independent of subsequent context-menu selection. Loading disables the button; replacing a model updates its source. This uses the existing NWListen extraction/progress workflow. The checkbox controls NWMax's import of the exported ASCII model's own animation blocks; preview-only merged supermodel clips are not baked into the Max transfer. Unchecked requests import geometry and skip controller reset/clip-gap processing. Export glTF continues to include the preview's merged clips regardless of this checkbox.

Validated 2026-11-25: full-framework Release/x86 build, 53 converter checks, synthetic weighted skin deformation, and copied K1 `p_bastilabb` (five ancestors, 268 clips) / K2 `p_handmaidenba` (six ancestors, 457 clips). Browser tests checked skin rest poses and 30 playback/pause/stop/restart cycles per clip. These checks establish hierarchy and playback stability, not exact game shader or animation-retargeting parity.

## Audio audition sidebar

The rightmost native sidebar has category and definition selectors. The Creatures category lists the selected game's `soundset.2da` entries and the 28 KotOR SSF event slots. SSF headers/table bounds are checked, StrRefs resolve through that game's `dialog.tlk`, and missing or silent events remain visibly unavailable. Soundset tables and SSFs resolve from enabled Override files, the selected archive, then the selected game's KEY. Sound playback uses the shared FMOD player (sounds BIFF and stream/voice files); archive-local WAV overrides are not staged by this feature. The player retains its existing audio lookup order.

An MDL does not contain the creature's `SoundSetFile` assignment: the [creature soundset lookup](https://github.com/seedhartha/reone/blob/master/src/libs/game/object/creature.cpp) uses UTC -> soundset.2da -> SSF. A soundset whose resource name exactly matches the displayed model is suggested, explicitly as a name match. Otherwise the user chooses one. No creature assignment is inferred from animation names, and no UTC/SSF/game files are edited.

Select an event to audition with **Play sound**, or enable **Play with animation**. The chosen event plays on clip selection/restart and at loop boundaries, pauses/resumes with animation playback, and stops on clip stop/completion. Selection changes, model loading/replacement and form disposal stop audio. This is manual paired audition, not automatic combat-event selection, exact authored-event timing, surface footsteps, weapon impacts or an audio-bearing glTF export. Sound controls are designer-owned; WebView2 sends only revision-checked playback state/reason messages to the native host.

Validated 2026-11-25: full-framework Release/x86 build; native DesignSurface/sidebar and WebView2 replacement/lifecycle checks; 150 inherited clip playback cycles; copied K1 (89 soundsets) and K2 (65 soundsets) SSF/TLK/WAV fixtures exercised playback, pause/resume, repeated stop and clearing on model replacement. Test harness files remain outside the application project/build payload.

### Additional audio categories

- Doors: `genericdoors.modelname` and `soundapptype` into `placeableobjsnds`.
- Containers / placeables: `placeables.modelname` and `soundapptype` into the same event table.
- Items / weapons: `baseitems.defaultmodel`, `invsoundtype` into `inventorysnds`, `weaponmattype` into `weaponsounds`, and direct powered-item sound columns.
- Environments / music: `ambientsound.resource` and `ambientmusic.resource`/stingers, with TLK descriptions where available.
- Menus / UI: `guisounds.soundresref`.

Only exact model references select a category automatically, and only a unique matching definition is selected. Missing sound mappings remain empty with an explanation. The complete event tables remain manually browsable, including definitions without model mappings; both Doors and Containers expose the shared placeable sound table. Referenced row labels are resolved through the table's row labels, not assumed to equal array offsets. Unknown columns remain untouched. Surface/material selection, event timing, pitch offsets and arbitrary scripted/UTS sounds are not simulated.

**Loop audio** repeats an independently auditioned sound through FMOD. It is disabled while **Play with animation** is enabled, which retains clip-start/loop pairing. Category changes and direct model replacement also stop audio. The player's new optional loop argument defaults to false, preserving existing dialogue playback callers.

The viewport no longer displays camera instructions, renderer limitations or parser/controller warning dumps beneath the model. Conversion warnings remain in exported glTF metadata; loading failures still display an error. Tests use viewport loading state rather than instructional text to detect readiness.

Validated with copied K1/K2 table/audio fixtures: all six categories populated and played audio; door and default-item exact mappings passed; missing tables cleared old choices; pause/resume and repeated stop passed. Full-framework Release/x86 build and native/WebView2 lifecycle smoke passed. The viewport capture confirms no diagnostic footer after successful load.

## VFX preview

Emitter-only MDLs now open in MDL Viewer. The ASCII converter retains emitter transforms and bounded numeric properties in glTF node `extras.auroraEmitter`, embedding their resolved textures. `web/vfx.js` renders textured Explosion, Fountain and Single particles with lifespan, velocity/spread, gravity/drag, size/color/opacity interpolation and texture atlas frames. The VFX toolbar supplies pause/play, replay and loop. Ordinary mesh models keep the existing toolbar only. Both meshes and emitters can coexist.

This is a development approximation: billboard alignment and motion blur are approximate; lightning, collision, point-to-point emitters, animated emitter parameter controllers and script/detonation timing are not reproduced. Export retains emitter metadata but standard glTF viewers do not simulate these particles. No game scripts execute. Limits are 128 emitters, 256 particles per emitter and 2,048 particles total; sprites are pooled and textures/materials disposed on navigation. Source files are unchanged.

Validation: Debug/x86 and Release/x86 full-framework builds; 60 converter checks including meshless emitters, modes, texture embedding and malformed properties; copied K1/K2 `v_blaster_imp` fixtures load with three textured emitters and pass browser pause/replay, bounded allocation and disposal checks. Existing inherited-animation browser smoke passes. Test fixtures and temporary harnesses remain outside the application payload.

## Bottom controls and animation timeline

The native MDL Viewer places Export glTF directly below Send to 3DS Max in the animation sidebar. `ViewerBottomBar` occupies the full-width `bottomControls` designer panel beneath both sidebars and the viewport. It supplies rotation, axis, reset, wireframe and conditional VFX controls, followed by a key track and transport controls. The embedded page hides its duplicate toolbar when opened with `native=1`; standalone browser fixtures retain their HTML controls.

The selected clip is displayed at 30 preview frames per second (MDL/glTF times remain seconds). Red, green and blue markers represent the actual position, rotation and scale track key times, including inherited clips. Shared key times are consolidated. Dragging the track or entering a frame pauses and samples the animation; arrow keys, Home/End, frame stepping, previous/next key and playback buttons are available. Key jumps preserve exact source times even for subframe keys. This is a read-only preview, not a keyframe editor. Pose-only clips remain at frame zero; models without transform clips disable the timeline. Particle simulation has its own controls and is not rewound by animation scrubbing. Scrubbing stops linked audio rather than playing it out of sync.

Browser messages carry the current model revision, key metadata on clip selection, and throttled time/control state updates. Loading disables native controls; replacement resets the timeline and VFX state. No timer or additional browser process is created for the timeline. Validation covers native layout, frame seek/step/start/end, key markers, VFX-only replacement, disposal and synthetic skinned/inherited pose sampling at scrubbed times.
