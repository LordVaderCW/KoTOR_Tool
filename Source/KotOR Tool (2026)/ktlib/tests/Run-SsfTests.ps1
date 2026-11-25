param([string]$LegacySource)
$ErrorActionPreference = 'Stop'
$solutionRoot = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
$vs = & $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -property installationPath
if (-not $vs) { throw 'Visual Studio MSBuild is required.' }
$msbuild = Join-Path $vs 'MSBuild\Current\Bin\MSBuild.exe'
& $msbuild (Join-Path $solutionRoot 'ktlib\ktlib.csproj') /p:Configuration=Debug /p:Platform=AnyCPU /nologo /v:quiet
if ($LASTEXITCODE -ne 0) { throw 'ktlib build failed.' }
$work = Join-Path ([IO.Path]::GetTempPath()) ('ktlib-ssf-tests-' + [guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $work | Out-Null
$framework = Join-Path ${env:ProgramFiles(x86)} 'Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2'
$compiler = Join-Path $vs 'MSBuild\Current\Bin\Roslyn'
$source = Join-Path $solutionRoot 'kotor_tool\Classes\SoundSystem\clsSSF.vb'
if ($LegacySource) { $source = (Resolve-Path -LiteralPath $LegacySource).Path }
Copy-Item -LiteralPath (Join-Path $solutionRoot 'ktlib\bin\Debug\ktlib.dll') -Destination $work
& (Join-Path $compiler 'vbc.exe') /nologo /target:library /optionstrict- "/sdkpath:$framework" "/out:$work\SsfHost.dll" "/reference:$work\ktlib.dll" $source (Join-Path $PSScriptRoot 'SsfHostStubs.vb')
if ($LASTEXITCODE -ne 0) { throw 'VB adapter test build failed.' }
& (Join-Path $compiler 'csc.exe') /nologo /target:exe /platform:x86 "/out:$work\SsfTests.exe" "/reference:$work\ktlib.dll" "/reference:$work\SsfHost.dll" (Join-Path $PSScriptRoot 'SsfTests.cs')
if ($LASTEXITCODE -ne 0) { throw 'SSF test harness build failed.' }
if ($LegacySource) { & "$work\SsfTests.exe" legacy } else { & "$work\SsfTests.exe" }
if ($LASTEXITCODE -ne 0) { throw 'SSF tests failed.' }
Write-Output "Test binaries retained at $work"
