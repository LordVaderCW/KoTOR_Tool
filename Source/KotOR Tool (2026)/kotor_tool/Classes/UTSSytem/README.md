# UTS Sound Object System

The directory name `UTSSytem` is misspelled in the project and is therefore a path compatibility detail. `clsUTS` is the GFF specialization for placed sound templates; `frmUTS_Editor` provides editing and FMOD preview.

Sound objects include ResRefs/variation lists plus volume, distance, positional/loop/random/interval and other playback flags. The editor's preview path also parses RIFF/WAVE and KoTOR embedded audio metadata.

Do not rename this directory without updating every `.vbproj`, source-control and documentation reference. Test GFF round trips plus playback start, natural completion, repeated play/stop, missing audio, malformed RIFF, cancel and close. FMOD `System`, `Sound` and `Channel` releases must remain idempotent.
