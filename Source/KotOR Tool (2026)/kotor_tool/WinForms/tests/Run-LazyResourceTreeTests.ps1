param(
    [Parameter(Mandatory=$true)][string]$Kotor1Path,
    [Parameter(Mandatory=$true)][string]$Kotor2Path,
    [ValidateSet('Debug','Release')][string]$Configuration = 'Release'
)
$ErrorActionPreference = 'Stop'
$solutionRoot = (Resolve-Path (Join-Path $PSScriptRoot '..\..\..')).Path
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
$vs = & $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -property installationPath
if (-not $vs) { throw 'Full-framework Visual Studio MSBuild is required.' }
& (Join-Path $vs 'MSBuild\Current\Bin\MSBuild.exe') (Join-Path $solutionRoot 'kotor_tool.sln') /t:Build "/p:Configuration=$Configuration" /p:Platform=x86 /nologo /v:minimal
if ($LASTEXITCODE -ne 0) { throw 'Application build failed.' }
$output = Join-Path $solutionRoot "kotor_tool\bin\x86\$Configuration"
$scratch = Join-Path ([IO.Path]::GetTempPath()) ('kotor-lazy-tests-' + [guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $scratch | Out-Null
Get-ChildItem -LiteralPath $output -File | Where-Object { $_.Extension -in '.exe','.dll','.config','.bfd','.xml' } | Copy-Item -Destination $scratch
Copy-Item -LiteralPath (Join-Path $output 'Themes') -Destination $scratch -Recurse
$gamePaths = @($Kotor1Path, $Kotor2Path)
for ($game = 0; $game -lt 2; $game++) {
    $fixture = Join-Path $scratch ('k' + ($game + 1))
    New-Item -ItemType Directory -Path (Join-Path $fixture 'data') -Force | Out-Null
    Copy-Item -LiteralPath (Join-Path $gamePaths[$game] 'chitin.key') -Destination $fixture
    # Startup extracts nwscript.nss; it must read and write only copied fixtures.
    Copy-Item -LiteralPath (Join-Path $gamePaths[$game] 'data\scripts.bif') -Destination (Join-Path $fixture 'data')
}
$testExe = Join-Path $scratch 'LazyResourceTreeTests.exe'
& (Join-Path $vs 'MSBuild\Current\Bin\Roslyn\csc.exe') /nologo /target:winexe /platform:x86 "/out:$testExe" "/reference:$scratch\kotor_tool.exe" /reference:System.Windows.Forms.dll /reference:System.Drawing.dll /reference:System.Core.dll (Join-Path $PSScriptRoot 'LazyResourceTreeTests.cs')
if ($LASTEXITCODE -ne 0) { throw 'Test compilation failed.' }
Copy-Item -LiteralPath (Join-Path $scratch 'kotor_tool.exe.config') -Destination ($testExe + '.config')
$probe = Start-Process -FilePath $testExe -ArgumentList 'k1\chitin.key k2\chitin.key' -WorkingDirectory $scratch -WindowStyle Hidden -PassThru
try {
    if (-not $probe.WaitForExit(30000)) {
        Stop-Process -Id $probe.Id
        throw 'Isolated tree test timed out.'
    }
    Get-Content -LiteralPath (Join-Path $scratch 'lazy-tree-results.txt')
    if ($probe.ExitCode -ne 0) { throw 'Lazy resource tree tests failed.' }
} finally {
    Write-Output "Copied fixtures retained at $scratch"
}
