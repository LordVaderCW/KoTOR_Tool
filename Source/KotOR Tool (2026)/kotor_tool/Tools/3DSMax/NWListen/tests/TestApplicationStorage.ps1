param(
    [string]$Application = (Join-Path $PSScriptRoot '..\..\..\..\bin\x86\Debug\kotor_tool.exe'),
    [string]$MaxBatch = 'C:\Program Files\Autodesk\3ds Max 2021\3dsmaxbatch.exe'
)
$ErrorActionPreference = 'Stop'
if ([Environment]::Is64BitProcess) { throw 'Run with SysWOW64\WindowsPowerShell\v1.0\powershell.exe to test the x86 sender.' }
$userKey = [Microsoft.Win32.RegistryKey]::OpenBaseKey('CurrentUser', 'Registry64')
$key = $userKey.CreateSubKey('Software\KotOR Tool\NWlisten')
$previous = $key.GetValue('ApplicationDirectory', $null)
$previousKind = if ($null -ne $previous) { $key.GetValueKind('ApplicationDirectory') } else { $null }
$previousEnvironment = $env:NWLISTEN_TEST_APPLICATION
try {
    $assembly = [Reflection.Assembly]::LoadFrom((Resolve-Path -LiteralPath $Application).Path)
    $method = $assembly.GetType('kotor_tool.frmMain', $true).GetMethod('NWRegisterApplicationDirectory', [Reflection.BindingFlags]'NonPublic,Static')
    if ($null -eq $method) { throw 'Sender registration helper missing.' }
    $testApplication = Join-Path $PSScriptRoot ('run-' + [Guid]::NewGuid().ToString('N') + '\KoTOR Tool (sender fixture)')
    $testApplication = [IO.Path]::GetFullPath($testApplication)
    $actual = $method.Invoke($null, @($testApplication))
    $expected = Join-Path $testApplication 'working\NWlisten'
    if ($actual -ne $expected -or !(Test-Path -LiteralPath $expected -PathType Container)) { throw 'Sender did not create application-local storage.' }
    if ($key.GetValue('ApplicationDirectory') -ne $testApplication) { throw 'Sender did not publish application directory.' }
    # An unwritable destination must fail before replacing registration, without a profile fallback.
    $blocked = Join-Path $testApplication 'blocked'
    [IO.File]::WriteAllText($blocked, 'file blocks directory creation')
    $failed = $false
    try { $null = $method.Invoke($null, @($blocked)) } catch { $failed = $true }
    if (!$failed -or $key.GetValue('ApplicationDirectory') -ne $testApplication) { throw 'Failed storage path changed registration or silently fell back.' }
    Write-Output 'PASS compiled x86 sender: application-local storage; write failure has no fallback'
    $cleanupTest = Join-Path $testApplication 'TestWorkingCleanup.exe'
    & "$env:WINDIR\Microsoft.NET\Framework\v4.0.30319\csc.exe" /nologo /platform:x86 /r:System.Windows.Forms.dll "/out:$cleanupTest" (Join-Path $PSScriptRoot 'TestWorkingCleanup.cs')
    if ($LASTEXITCODE -ne 0) { throw 'Cleanup fixture compilation failed.' }
    & $cleanupTest (Resolve-Path -LiteralPath $Application).Path
    if ($LASTEXITCODE -ne 0) { throw 'Working cleanup test failed.' }
    $env:NWLISTEN_TEST_APPLICATION = $testApplication
    & $MaxBatch (Join-Path $PSScriptRoot 'BridgeSmoke.ms') -v 2 *> (Join-Path $PSScriptRoot 'batch.log')
    if ($LASTEXITCODE -ne 0) { throw "Max batch exited with $LASTEXITCODE" }
    $results = Get-Content -LiteralPath (Join-Path $PSScriptRoot 'results.txt') -Raw
    Write-Output $results
    if ($results -match 'FAIL' -or $results -notmatch 'PASS application relocation and unregister') { throw 'Bridge smoke tests failed or did not finish.' }
} finally {
    if ($null -eq $previous) { $key.DeleteValue('ApplicationDirectory', $false) }
    else { $key.SetValue('ApplicationDirectory', $previous, $previousKind) }
    $key.Dispose()
    $userKey.Dispose()
    $env:NWLISTEN_TEST_APPLICATION = $previousEnvironment
}
