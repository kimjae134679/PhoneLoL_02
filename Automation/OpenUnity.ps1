param(
    [string]$EditorPath = 'C:\Program Files_My\A_3D\Unity_Hub\Unity_Editor\6000.3.14f1\Editor\Unity.exe'
)
$ErrorActionPreference = 'Stop'
$projectPath = Join-Path (Split-Path $PSScriptRoot -Parent) 'PhoneLOL-02'
if (-not (Test-Path $EditorPath)) { throw "Unity Editor not found: $EditorPath" }
# Remote launchers can omit standard Windows variables required by Package Manager.
if (-not $env:ProgramData) { $env:ProgramData = [Environment]::GetFolderPath('CommonApplicationData') }
if (-not $env:ALLUSERSPROFILE) { $env:ALLUSERSPROFILE = $env:ProgramData }
if (-not $env:TMP) { $env:TMP = [IO.Path]::GetTempPath() }
if (-not $env:ComSpec) { $env:ComSpec = Join-Path $env:SystemRoot 'System32\cmd.exe' }
if (-not [Environment]::GetEnvironmentVariable('ProgramFiles(x86)')) {
    [Environment]::SetEnvironmentVariable('ProgramFiles(x86)', [Environment]::GetFolderPath('ProgramFilesX86'), 'Process')
}
$existing = Get-CimInstance Win32_Process -Filter "name = 'Unity.exe'" |
    Where-Object { $_.CommandLine -and $_.CommandLine.Contains($projectPath) }
if ($existing) {
    Write-Output "The project is already open; no second Editor was started."
    exit 0
}
Start-Process -FilePath $EditorPath -ArgumentList @('-projectPath', ('"' + $projectPath + '"'))
