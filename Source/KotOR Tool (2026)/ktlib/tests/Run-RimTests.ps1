$ErrorActionPreference = 'Stop'
$solutionRoot = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
$vs = & $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -property installationPath
if (-not $vs) { throw 'Visual Studio MSBuild is required.' }
& (Join-Path $vs 'MSBuild\Current\Bin\MSBuild.exe') (Join-Path $solutionRoot 'ktlib\ktlib.csproj') /p:Configuration=Debug /p:Platform=AnyCPU /nologo /v:quiet
if ($LASTEXITCODE -ne 0) { throw 'ktlib build failed.' }
$work = Join-Path ([IO.Path]::GetTempPath()) ('ktlib-rim-tests-' + [guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $work | Out-Null
$framework = Join-Path ${env:ProgramFiles(x86)} 'Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2'
$compiler = Join-Path $vs 'MSBuild\Current\Bin\Roslyn'
Copy-Item -LiteralPath (Join-Path $solutionRoot 'ktlib\bin\Debug\ktlib.dll') -Destination $work
$reader = Join-Path $solutionRoot 'kotor_tool\Classes\RIMSystem\clsRIM.vb'
$entry = Join-Path $solutionRoot 'kotor_tool\Classes\RIMSystem\RIMKeyEntry.vb'
& (Join-Path $compiler 'vbc.exe') /nologo /target:library "/sdkpath:$framework" "/out:$work\RimHost.dll" $reader $entry (Join-Path $PSScriptRoot 'RimHostStubs.vb')
if ($LASTEXITCODE -ne 0) { throw 'VB RIM reference build failed.' }
& (Join-Path $compiler 'csc.exe') /nologo /target:exe /platform:x86 "/out:$work\RimTests.exe" "/reference:$work\ktlib.dll" "/reference:$work\RimHost.dll" (Join-Path $PSScriptRoot 'RimTests.cs')
if ($LASTEXITCODE -ne 0) { throw 'RIM test harness build failed.' }
& "$work\RimTests.exe"
if ($LASTEXITCODE -ne 0) { throw 'RIM tests failed.' }
Write-Output "Test binaries retained at $work"
