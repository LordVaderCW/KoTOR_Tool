$ErrorActionPreference = 'Stop'
$solutionRoot = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
$vs = & $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -property installationPath
if (-not $vs) { throw 'Visual Studio MSBuild is required.' }
& (Join-Path $vs 'MSBuild\Current\Bin\MSBuild.exe') (Join-Path $solutionRoot 'ktlib\ktlib.csproj') /p:Configuration=Debug /p:Platform=AnyCPU /nologo /v:quiet
if ($LASTEXITCODE -ne 0) { throw 'ktlib build failed.' }
$work = Join-Path ([IO.Path]::GetTempPath()) ('ktlib-2da-tests-' + [guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $work | Out-Null
$framework = Join-Path ${env:ProgramFiles(x86)} 'Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2'
$compiler = Join-Path $vs 'MSBuild\Current\Bin\Roslyn'
Copy-Item -LiteralPath (Join-Path $solutionRoot 'ktlib\bin\Debug\ktlib.dll') -Destination $work
$referenceRoot = Join-Path $solutionRoot 'kotor_tool\Classes\2DASystem'
$sources = @('cls2DA.vb', 'clsBaseItems2DA.vb') | ForEach-Object { Join-Path $referenceRoot $_ }
$sources += Join-Path $solutionRoot 'kotor_tool\Classes\ItemSystem\TreeBaseItem.vb'
$sources += Join-Path $PSScriptRoot 'TwoDaHostStubs.vb'
& (Join-Path $compiler 'vbc.exe') /nologo /target:library "/sdkpath:$framework" "/out:$work\TwoDaHost.dll" @sources
if ($LASTEXITCODE -ne 0) { throw 'VB 2DA reference build failed.' }
& (Join-Path $compiler 'csc.exe') /nologo /target:exe /platform:x86 "/out:$work\TwoDaTests.exe" "/reference:$work\ktlib.dll" "/reference:$work\TwoDaHost.dll" (Join-Path $PSScriptRoot 'TwoDaTests.cs')
if ($LASTEXITCODE -ne 0) { throw 'BIFF test harness build failed.' }
& "$work\TwoDaTests.exe" $work
if ($LASTEXITCODE -ne 0) { throw '2DA tests failed.' }
Write-Output "Test binaries and synthetic fixtures retained at $work"
