# NCS System

`clsNCS.DecompileAndOpen` sanitizes/writes an NCS under `working/NCSDecompile`, finds the `ncs`+`decompile` plugin, validates files, executes it and opens Windows-1252/ASCII NSS output. Verify output even on exit 0; test both games, missing payload, timeout, stderr and unsafe names.
