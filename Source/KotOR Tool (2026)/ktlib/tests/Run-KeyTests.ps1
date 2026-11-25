$ErrorActionPreference = 'Stop'
$solutionRoot = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
$vs = & $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -property installationPath
if (-not $vs) { throw 'Visual Studio MSBuild is required.' }
& (Join-Path $vs 'MSBuild\Current\Bin\MSBuild.exe') (Join-Path $solutionRoot 'ktlib\ktlib.csproj') /p:Configuration=Debug /p:Platform=AnyCPU /nologo /v:quiet
if ($LASTEXITCODE -ne 0) { throw 'ktlib build failed.' }
$work = Join-Path ([IO.Path]::GetTempPath()) ('ktlib-key-tests-' + [guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $work | Out-Null
$framework = Join-Path ${env:ProgramFiles(x86)} 'Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2'
$compiler = Join-Path $vs 'MSBuild\Current\Bin\Roslyn'
Copy-Item -LiteralPath (Join-Path $solutionRoot 'ktlib\bin\Debug\ktlib.dll') -Destination $work
$referenceRoot = Join-Path $solutionRoot 'kotor_tool\Classes\BIFFSystem'
$sources = @('BIFFArchive.vb', 'BIFFVarRsrcEntry.vb', 'BIFFVarRsrcEntryInfo.vb') | ForEach-Object { Join-Path $referenceRoot $_ }
$sources += @('clsChitinKey.vb', 'KeyEntry.vb') | ForEach-Object { Join-Path (Join-Path $solutionRoot 'kotor_tool\Classes\Security') $_ }
$sources += Join-Path $referenceRoot 'BIFFEntry.vb'
$sources += Join-Path $PSScriptRoot 'RimHostStubs.vb'
& (Join-Path $compiler 'vbc.exe') /nologo /target:library "/sdkpath:$framework" "/out:$work\KeyHost.dll" @sources
if ($LASTEXITCODE -ne 0) { throw 'VB KEY reference build failed.' }
& (Join-Path $compiler 'csc.exe') /nologo /target:exe /platform:x86 "/out:$work\KeyTests.exe" "/reference:$work\ktlib.dll" "/reference:$work\KeyHost.dll" (Join-Path $PSScriptRoot 'KeyTests.cs')
if ($LASTEXITCODE -ne 0) { throw 'BIFF test harness build failed.' }
& "$work\KeyTests.exe" $work
if ($LASTEXITCODE -ne 0) { throw 'KEY tests failed.' }
Write-Output "Test binaries and synthetic fixtures retained at $work"
