# NCS Script System

`clsNCS.DecompileAndOpen` bridges an extracted compiled script to the plugin system:

1. sanitize the resource filename;
2. write `.ncs` bytes under `working/NCSDecompile`;
3. load plugins and find the `ncs` + `decompile` handle;
4. validate all required plugin files;
5. run the command with the normalized game number;
6. read the expected `.nss` output using Windows-1252/ASCII fallback and open it in `frmTextEditor`.

This workflow does not prepare the editor for compilation and deliberately does not require `nwscript.nss` from Override; DeNCS supplies its own game-specific copy.

Treat input/output and plugin paths as untrusted. Preserve timeout/failure diagnostics, delete only the exact prior generated output, and never treat exit success as sufficient without verifying the output file. Test both games, duplicate names, invalid filenames, missing plugin files, timeout/nonzero exit/stderr and source encodings.
