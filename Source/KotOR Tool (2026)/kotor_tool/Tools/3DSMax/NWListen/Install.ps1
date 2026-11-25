param([string]$MaxRoot = 'C:\Program Files\Autodesk\3ds Max 2021')
$ErrorActionPreference = 'Stop'
$destination = Join-Path $MaxRoot 'scripts\NWlisten'
New-Item -ItemType Directory -Force -Path $destination | Out-Null
Copy-Item -LiteralPath (Join-Path $PSScriptRoot 'NWlisten.ms') -Destination $destination
Copy-Item -LiteralPath (Join-Path $PSScriptRoot 'NWlistenStartup.ms') -Destination (Join-Path $MaxRoot 'scripts\Startup\NWlistenStartup.ms')
# Draw the toolbar glyph at each supported DPI: a cyan cube and gold send arrow.
Add-Type -AssemblyName System.Drawing
foreach ($size in @(24,30,36,48)) {
    $bitmap = New-Object System.Drawing.Bitmap($size,$size)
    $graphics = [System.Drawing.Graphics]::FromImage($bitmap)
    $graphics.SmoothingMode = 'AntiAlias'
    $graphics.ScaleTransform(($size/24.0),($size/24.0))
    $cyan = New-Object System.Drawing.Pen([System.Drawing.Color]::FromArgb(80,205,235),1.6)
    $gold = New-Object System.Drawing.Pen([System.Drawing.Color]::FromArgb(245,193,75),2.0)
    $points = [System.Drawing.PointF[]]@([System.Drawing.PointF]::new(3,7),[System.Drawing.PointF]::new(10,3),[System.Drawing.PointF]::new(17,7),[System.Drawing.PointF]::new(17,15),[System.Drawing.PointF]::new(10,19),[System.Drawing.PointF]::new(3,15),[System.Drawing.PointF]::new(3,7))
    $graphics.DrawLines($cyan,$points)
    $graphics.DrawLine($cyan,3,7,10,11)
    $graphics.DrawLine($cyan,17,7,10,11)
    $graphics.DrawLine($cyan,10,11,10,19)
    $graphics.DrawLine($gold,13,18,22,18)
    $graphics.DrawLine($gold,18,14,22,18)
    $graphics.DrawLine($gold,18,22,22,18)
    foreach ($theme in @('Dark','Light')) {
        $icons = Join-Path $MaxRoot "UI_ln\Icons\$theme\NWlisten"
        New-Item -ItemType Directory -Force -Path $icons | Out-Null
        $bitmap.Save((Join-Path $icons "NWlisten_$size.png"),[System.Drawing.Imaging.ImageFormat]::Png)
    }
    $gold.Dispose(); $cyan.Dispose(); $graphics.Dispose(); $bitmap.Dispose()
}
Write-Output "Installed NWlisten to $destination. Run NWlisten.ms once in the current Max session, or restart Max. Customize User Interface > NWlisten > NWlisten supplies the toolbar action and icon."
