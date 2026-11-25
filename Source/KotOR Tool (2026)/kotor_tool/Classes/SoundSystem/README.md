# Sound System

<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/SoundSystem/README.md
`clsSSF` reads/writes `SSF V1.1` sound-set files as a fixed array of TLK StrRefs and can resolve display/sound data through `clsDialogTlk`. `KTSoundInfo` carries parsed sound metadata used by preview UI.

Actual playback is in `WinForms/frmUTS_Editor.vb` through FMOD. That form validates RIFF/WAVE chunks, preserves KoTOR embedded-MPEG offsets and centralizes stop/release cleanup.

Keep SSF slot order and count exact. Treat `-1`/missing StrRefs as distinct from empty strings. For audio, parse FourCCs as raw ASCII bytes, skip unknown RIFF chunks with padding rules, bounds-check lengths and make FMOD release idempotent. Test plain WAVE, KoTOR WAVE/embedded MPEG, unknown chunks, truncated data, natural playback completion, stop, cancel and form close.
=======
`clsSSF` reads/writes fixed `SSF V1.1` TLK reference slots. `clsAnimationSoundPlayer` resolves Override/stream/archive audio and owns FMOD initialization, timer polling and idempotent stop/release/dispose; `KTSoundInfo` carries preview metadata. Test both games, lookup precedence, RIFF/embedded MPEG, natural finish, repeat stop and close.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/SoundSystem/README.md

The model preview reuses `clsAnimationSoundPlayer` for soundset audition. `PauseSound(Boolean)` delegates to the current FMOD channel without restarting it; StopSound and Dispose retain ownership of channel/sound release. The preview owns/disposes its player and stops it before loading another model. No soundset files are written.

`PlayResRef` accepts an optional `loopAudio` argument (default false). The preview uses FMOD loop mode for independent environmental/music and other audio audition; clip-paired playback keeps the normal one-shot mode. Existing dialogue callers retain their previous default behavior.

Archive audio lookup uses a private `StringComparer.OrdinalIgnoreCase` copy of the sounds BIFF index. Game tables contain mixed-case references such as `dr_LDA02_close`, while KEY entries commonly use lowercase. The shared KEY cache, resource spelling and stream lookup order remain unchanged.

Validated 2026-11-25 against copied K1/K2 KEY, sounds BIFF and placeable sound-table fixtures: reproduced the mixed-case failures before the change; mixed/lower/uppercase open/close names and the metal-lock control pass afterward. All archive-present open/close table entries passed (K1: 131; K2: 151); one K1 reference was absent from the archive. Missing-resource failure, repeated stop and unchanged shared-index behavior also passed.
