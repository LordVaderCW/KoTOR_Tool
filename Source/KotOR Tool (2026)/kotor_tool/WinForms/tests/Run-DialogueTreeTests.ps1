param(
    [Parameter(Mandatory=$true)][string]$Kotor1Path,
    [Parameter(Mandatory=$true)][string]$Kotor2Path
)
$ErrorActionPreference = 'Stop'
$solutionRoot = (Resolve-Path (Join-Path $PSScriptRoot '..\..\..')).Path
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
$vs = & $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -property installationPath
if (-not $vs) { throw 'Full-framework Visual Studio MSBuild is required.' }
& (Join-Path $vs 'MSBuild\Current\Bin\MSBuild.exe') (Join-Path $solutionRoot 'kotor_tool.sln') /t:Build /p:Configuration=Release /p:Platform=x86 /nologo /v:minimal
if ($LASTEXITCODE -ne 0) { throw 'Application build failed.' }
$output = Join-Path $solutionRoot 'kotor_tool\bin\x86\Release'
$testExe = Join-Path $output 'DialogueTreeTests.exe'
& (Join-Path $vs 'MSBuild\Current\Bin\Roslyn\csc.exe') /nologo /target:exe /platform:x86 "/out:$testExe" "/reference:$output\kotor_tool.exe" /reference:System.Windows.Forms.dll (Join-Path $PSScriptRoot 'DialogueTreeTests.cs')
if ($LASTEXITCODE -ne 0) { throw 'Test compilation failed.' }
$scratch = Join-Path ([IO.Path]::GetTempPath()) ('dialogue-tree-' + [guid]::NewGuid().ToString('N'))
try {
    & $testExe $Kotor1Path $Kotor2Path $scratch
    if ($LASTEXITCODE -ne 0) { throw 'Dialogue index tests failed.' }
} finally {
    Remove-Item -LiteralPath $testExe -ErrorAction SilentlyContinue
    Write-Output "Copied fixtures retained at $scratch"
}
