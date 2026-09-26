param(
    [Parameter(Mandatory = $true)][AllowEmptyString()][string]$Headline,
    [Parameter(Mandatory = $true)][AllowEmptyString()][string]$Body
)
$ErrorActionPreference = 'Stop'
if ($Headline.Length -gt 120 -or $Body.Length -gt 3000) {
    throw 'Headline must be <=120 characters and body <=3000 characters.'
}
$serverPath = Join-Path $env:USERPROFILE 'Documents\MultiGod\PhoneLOL_LocalRuntime\recovery\01_server_v0965_snapshot\APK'
$target = Join-Path $serverPath 'lobby-notice.json'
$tempPath = Join-Path $serverPath ('lobby-notice.' + [guid]::NewGuid().ToString('N') + '.tmp')
$backup = Join-Path $serverPath 'lobby-notice.previous.json'
$json = @{ headline = $Headline; body = $Body } | ConvertTo-Json -Compress
if ([System.Text.Encoding]::UTF8.GetByteCount($json) -gt 8192) { throw 'Notice UTF-8 JSON exceeds 8192 bytes.' }
[System.IO.File]::WriteAllText($tempPath, $json, [System.Text.UTF8Encoding]::new($false))
if ([System.IO.File]::Exists($target)) {
    [System.IO.File]::Replace($tempPath, $target, $backup)
} else {
    [System.IO.File]::Move($tempPath, $target)
}
Write-Host ('Updated lobby notice: ' + $target)
