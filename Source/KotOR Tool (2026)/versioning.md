# Versioning

## Current release: 1.0.3.5a

`AssemblyInformationalVersion` supplies the displayed product version `1.0.3.5a`. Assembly and file versions remain numeric at `1.0.3.5`. README and changelog use the product version. These values supersede the historical version snapshots below; alphabetic patch suffixes must not be placed in `AssemblyVersion` or `AssemblyFileVersion`.

<<<<<<< HEAD:Source/KotOR Tool (2026)/versioning.md
## Current application version

The authoritative compiled version is currently the assembly version in `My Project/AssemblyInfo.vb`: `1.0.3.04`. .NET displays this numerically as `1.0.3.4`, matching `README.md` and `Changelog.txt` (`v1.0.3.4`). `Application.ProductVersion` is used in the title/about/error UI and written into some GFF/BWM metadata.

## Other version domains

| Domain | Current value | Notes |
| --- | --- | --- |
| Assembly/application display | `1.0.3.4` | Primary runtime version |
| ClickOnce `ApplicationVersion` | `1.0.0.*` | Stale project metadata; updater is disabled/legacy |
| DeNCS plugin | `1.0.2` | Independent plugin version |
| DeNCS minimum application | `1.0.3.3` | Manifest compatibility floor |
| Theme format | `1` | INI schema version, independent of app version |

Historical changelog labels are not all normalized (for example `v1.0.23`). Preserve them as history unless evidence establishes a typo; do not make them drive runtime comparisons.

## Release rules

1. Use four numeric assembly components and display them without artificial zero padding.
2. Update `AssemblyInfo.vb`, the README current version and the top changelog release together.
3. If deployment/updater support is re-enabled, align `ApplicationVersion` and document its comparison semantics.
4. Version plugin manifests/catalogs independently and update installed records only after successful installation.
5. Increment theme/plugin schema versions only for parser-visible contract changes.
6. Build Debug and Release x86, smoke-test startup and changed editors, and package copied dependencies from a clean output.
7. Tag source with the displayed application version and attach hashes/provenance for distributed opaque binaries.

## Recommended future source of truth

Move the application version into one generated/shared MSBuild property and derive assembly, documentation and packaging values from it. Until that work is intentional, `AssemblyInfo.vb` remains the runtime source of truth.
=======
`My Project/AssemblyInfo.vb` is the runtime source: `1.0.3.04`, displayed as `1.0.3.4`. README/changelog should match it; ClickOnce `ApplicationVersion` remains stale at `1.0.0.*`.

Plugin versions are independent: DeNCS `1.0.2` and MDLOps `1.0.2`. Theme schema versions are independent.

Update assembly/README/changelog together, align deployment metadata if revived, build Debug/Release x86, smoke-test changed workflows, tag with the display version and publish hashes/provenance for opaque binaries.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/versioning.md
