# Sound System

`clsSSF` reads/writes fixed `SSF V1.1` TLK reference slots. `clsAnimationSoundPlayer` resolves Override/stream/archive audio and owns FMOD initialization, timer polling and idempotent stop/release/dispose; `KTSoundInfo` carries preview metadata. Test both games, lookup precedence, RIFF/embedded MPEG, natural finish, repeat stop and close.
