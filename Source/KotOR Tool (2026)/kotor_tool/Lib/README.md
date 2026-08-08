# Checked-in Libraries

This directory is the compile-time reference location for opaque managed dependencies and also contains a native FMOD copy.

| File | Purpose |
| --- | --- |
| `FMODCL.dll` | Managed wrapper referenced by the VB project |
| `fmodex.dll` | Native FMOD Ex 4.1.5 engine; a deployed copy also exists at the application root |
| `ImageTools.dll` | Legacy image helper library |
| `RTFLinenumberTextBox.dll` | Line-numbered text editor control |

Do not rebuild, patch or replace these binaries without explicit provenance, licensing, version/architecture inspection and feature tests. Keep `FMODCL.dll` compatible with the native `fmodex.dll` and the x86 process. Avoid allowing the root and `Lib` copies to drift; document which copy is compile-time and which is copied/deployed.
