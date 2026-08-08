# Sound System

`clsSSF` reads/writes `SSF V1.1` sound-set files as a fixed array of TLK StrRefs and can resolve display/sound data through `clsDialogTlk`. `KTSoundInfo` carries parsed sound metadata used by preview UI.

Actual playback is in `WinForms/frmUTS_Editor.vb` through FMOD. That form validates RIFF/WAVE chunks, preserves KoTOR embedded-MPEG offsets and centralizes stop/release cleanup.

Keep SSF slot order and count exact. Treat `-1`/missing StrRefs as distinct from empty strings. For audio, parse FourCCs as raw ASCII bytes, skip unknown RIFF chunks with padding rules, bounds-check lengths and make FMOD release idempotent. Test plain WAVE, KoTOR WAVE/embedded MPEG, unknown chunks, truncated data, natural playback completion, stop, cancel and form close.
