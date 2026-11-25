param([Parameter(Mandatory=$true)][string]$RuntimeRoot)
$ErrorActionPreference = 'Stop'
$root = (Resolve-Path -LiteralPath $RuntimeRoot).Path
[xml]$rules = Get-Content -LiteralPath (Join-Path $PSScriptRoot 'WebView2Packaging.targets')
$excluded = @($rules.Project.ItemGroup.WebView2OmittedRelativePath | ForEach-Object { $_.Include })
$files = @(Get-ChildItem -LiteralPath $root -File -Recurse | Where-Object {
    $relative = $_.FullName.Substring($root.Length + 1)
    $relative -notin $excluded -and ($relative -notlike 'Locales\*.pak' -or $_.Name -in @('en-US.pak','en-GB.pak'))
} | Sort-Object FullName)
$destination = Join-Path (Split-Path $root) 'webview2.cab'
$stamp = $destination + '.inputs'
$fingerprint = [IO.File]::ReadAllText($PSCommandPath) + [IO.File]::ReadAllText((Join-Path $PSScriptRoot 'WebView2Packaging.targets'))
$fingerprint += ($files | ForEach-Object { $_.FullName + '|' + $_.Length + '|' + $_.LastWriteTimeUtc.Ticks }) -join "`n"
if ((Test-Path -LiteralPath $destination) -and (Test-Path -LiteralPath $stamp) -and [IO.File]::ReadAllText($stamp) -eq $fingerprint) { exit 0 }
$staging = Join-Path (Split-Path $root) ('cab-build-' + [guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $staging | Out-Null
try {
    $ddf = @('.OPTION EXPLICIT','.Set Cabinet=on','.Set Compress=on','.Set CompressionType=MSZIP','.Set MaxDiskSize=0','.Set CabinetNameTemplate=webview2.cab',('.Set DiskDirectoryTemplate="' + $staging + '"'))
    foreach ($file in $files) {
        $relative = $file.FullName.Substring($root.Length + 1)
        $ddf += '"' + $file.FullName + '" "' + $relative + '"'
    }
    $ddfPath = Join-Path $staging 'runtime.ddf'
    [IO.File]::WriteAllLines($ddfPath,$ddf,[Text.Encoding]::Default)
    Push-Location $staging
    try {
        & "$env:WINDIR\System32\makecab.exe" /F $ddfPath > (Join-Path $staging 'makecab.log')
        if ($LASTEXITCODE -ne 0) { throw "WebView2 CAB creation failed: $(Get-Content (Join-Path $staging 'makecab.log') -Tail 8)" }
    } finally { Pop-Location }
    Move-Item -LiteralPath (Join-Path $staging 'webview2.cab') -Destination $destination -Force
    [IO.File]::WriteAllText($stamp,$fingerprint)
} finally {
    # Only this invocation's generated staging directory, verified within runtime/.
    if ([IO.Path]::GetFullPath($staging).StartsWith((Split-Path $root) + '\',[StringComparison]::OrdinalIgnoreCase)) { Remove-Item -LiteralPath $staging -Recurse -Force }
}
