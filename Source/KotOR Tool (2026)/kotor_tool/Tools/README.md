# Bundled Tools

Tool payloads used internally by plugin workflows live here. They are executable third-party dependencies, not source. Keep provenance/licenses/versions, copy metadata and exact invocation paths documented; never search an untrusted working directory ahead of the bundled location.

[3DSMax](3DSMax/README.md) additionally contains editable NWListen bridge source and the NWMax script/runtime snapshot. These non-compiled project items are copied to the application's `Tools\3DSMax` output folder when newer, excluding tests and generated artifacts. Builds do not install them into Max or execute them.
