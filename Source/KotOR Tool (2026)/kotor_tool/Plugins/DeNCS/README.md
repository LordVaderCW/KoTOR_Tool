# DeNCS Plugin Descriptor

This directory currently contains only metadata for OpenKotOR DeNCS 1.0.2:

- `plugin.xml` registers the `ncs` + `decompile` handle and required files.
- `command.ini` runs `NCSDecompCLI.exe` with input, output and game-specific `{nwscript}`, captures stdout/stderr, hides the window and uses a 15-second timeout.

## Required runtime payload

The manifest also requires `NCSDecompCLI.exe`, `tools/k1_nwscript.nss`, `tools/tsl_nwscript.nss`, `tools/nwnnsscomp_kscript.exe` and `tools/nwnnsscomp_ktool.exe`; optional `NCSDecompCLI.jar` may be present. These files are absent from this source snapshot, so validation should report the installed record as incomplete until the plugin installer supplies them.

Do not weaken required-file validation to make the metadata-only checkout appear complete. Test both game-specific `nwscript` selections, paths with spaces, timeout, nonzero exit, stderr-with-success, missing output and malformed NCS input. Review upstream license/provenance before packaging the payload.
