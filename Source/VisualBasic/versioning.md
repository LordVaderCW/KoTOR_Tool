# Versioning

`My Project/AssemblyInfo.vb` is the runtime source: `1.0.3.04`, displayed as `1.0.3.4`. README/changelog should match it; ClickOnce `ApplicationVersion` remains stale at `1.0.0.*`.

Plugin versions are independent: DeNCS `1.0.2` and MDLOps `1.0.2`. Theme schema versions are independent.

Update assembly/README/changelog together, align deployment metadata if revived, build Debug/Release x86, smoke-test changed workflows, tag with the display version and publish hashes/provenance for opaque binaries.
