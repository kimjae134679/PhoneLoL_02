param(
  [ValidateSet('Start','Status','Stop')][string]$Action='Status',
  [switch]$LocalOnly=$true,
  [switch]$NoMonitor
)
$ErrorActionPreference='Stop'
$SourceLauncherRoot=Split-Path -Parent $MyInvocation.MyCommand.Path
$CandidateRepoRoot=Split-Path -Parent (Split-Path -Parent $SourceLauncherRoot)
$RepoRoot=if(Test-Path -LiteralPath (Join-Path $CandidateRepoRoot 'APK\server_central_authority_v33.py')){$CandidateRepoRoot}else{'C:\Users\user\Documents\MultiGod\PhoneLOL_v1155'}
$RuntimeRoot='C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime'
$TestRoot=Join-Path $RuntimeRoot '00_PHONELOL_TEST_HERE'
$RecoveryRoot=Join-Path $RuntimeRoot 'recovery'
$ServerDst=Join-Path $RecoveryRoot '01_server_v0965_snapshot\APK'
$Control=Join-Path $RecoveryRoot 'CENTRAL_AUTHORITY_CONTROL_V33.ps1'
$Portwarp=Join-Path $RuntimeRoot 'tools\portwarp\pwrp.exe'
$Monitor=Join-Path $TestRoot 'monitor\RUN_MONITOR.cmd'
$Python='C:\TempPy13\python.exe'
# Use the current managed overlay and retain inherited dependencies in the legacy bundle.
$ManagedServerRoot='D:\A_KJ\AI\PhoneLoL_02\Automation\Server'
$ManagedFiles=@('server_central_authority_v33.py','account_services_v1158.py','managed_battle_v1167.py','managed_results_v1168.py','managed_rune_catalog.json')
$ManifestSrc=Join-Path $ManagedServerRoot 'central_v33_runtime_files.json'
function Get-BundleSource([string]$Name) {
  if($ManagedFiles-contains$Name){return (Join-Path $ManagedServerRoot $Name)}
  return (Join-Path (Join-Path $RepoRoot 'APK') $Name)
}
$PublicHost='115.88.104.135';$PublicPort=10045
$ExpectedServer='server_central_authority_v33.py'
$LauncherVersion='PhoneLOL Test Launcher V2.14 / managed 1.16.9'
. (Join-Path $SourceLauncherRoot 'PHONELOL_PROCESS_IDENTITY.ps1')
$ExpectedProgram=Join-Path $ServerDst $ExpectedServer
$KnownPrograms=@(
  $ExpectedProgram,
  'C:\Users\user\Documents\MultiGod\PhoneLOL\APK\server_v4_v10137_runtime.py'
)
$KnownPrograms+=@(Get-ChildItem -LiteralPath $ServerDst -Filter 'server_central_authority_*.py' -File -ErrorAction SilentlyContinue|Select-Object -ExpandProperty FullName)


function Read-Manifest {
  if(!(Test-Path -LiteralPath $ManifestSrc -PathType Leaf)){throw "Missing runtime manifest: $ManifestSrc"}
  $manifest=Get-Content -LiteralPath $ManifestSrc -Raw | ConvertFrom-Json
  if([string]$manifest.entrypoint-ne$ExpectedServer){throw "Unexpected runtime entrypoint: $($manifest.entrypoint)"}
  $files=@($manifest.files|ForEach-Object{[string]$_})
  if($files.Count-eq0-or!($files-contains$ExpectedServer)){throw 'Runtime manifest is empty or missing the V3.3 entrypoint.'}
  return [pscustomobject]@{Raw=$manifest;Files=$files}
}

function Test-SourceBundle {
  if(!(Test-Path -LiteralPath $Python -PathType Leaf)){throw "Python missing: $Python"}
  $bundle=Read-Manifest
  $temp=Join-Path ([IO.Path]::GetTempPath()) ('PhoneLOL_V33_Preflight_'+[guid]::NewGuid().ToString('N'))
  $oldNoByte=$env:PYTHONDONTWRITEBYTECODE
  try{
    New-Item -ItemType Directory -Force $temp|Out-Null
    foreach($name in $bundle.Files){
      $src=Get-BundleSource $name
      if(!(Test-Path -LiteralPath $src -PathType Leaf)){throw "Runtime dependency missing in repo: $name"}
      Copy-Item -LiteralPath $src -Destination (Join-Path $temp $name) -Force
    }
    $smoke=Join-Path $temp 'v33_preflight.py'
    @'
from pathlib import Path
import server_central_authority_v33 as server
root = Path(__file__).resolve().parent
srv = server.build_server("127.0.0.1", 0, str(root / "preflight.db"))
try:
    assert srv.server_address[1] > 0
    assert srv.state.managed_battle is not None
    assert srv.state.account_services.results is not None
    print("PHONELOL_V33_PREFLIGHT_PASS")
finally:
    srv.server_close()
    srv.state.close()
'@ | Set-Content -LiteralPath $smoke -Encoding UTF8
    $env:PYTHONDONTWRITEBYTECODE='1'
    $output=& $Python -S $smoke 2>&1|Out-String
    if($LASTEXITCODE-ne0-or$output-notmatch'PHONELOL_V33_PREFLIGHT_PASS'){throw "V3.3 isolated import/bind preflight failed.`n$output"}
  }finally{
    $env:PYTHONDONTWRITEBYTECODE=$oldNoByte
    if(Test-Path -LiteralPath $temp){Remove-Item -LiteralPath $temp -Recurse -Force -ErrorAction SilentlyContinue}
  }
}

function Test-RuntimeWritable {
  $probe=Join-Path $RuntimeRoot ('.phonelol_write_probe_'+[guid]::NewGuid().ToString('N'))
  try{
    New-Item -ItemType Directory -Force $RuntimeRoot|Out-Null
    New-Item -ItemType Directory -Force $probe|Out-Null
    Set-Content -LiteralPath (Join-Path $probe 'probe.txt') -Value 'ok' -Encoding Ascii
  }catch{
    throw "Runtime path is not writable: $RuntimeRoot . Keep the approved runtime path and fix its Windows permission/runner account access before deployment. $($_.Exception.Message)"
  }finally{
    if(Test-Path -LiteralPath $probe){Remove-Item -LiteralPath $probe -Recurse -Force -ErrorAction SilentlyContinue}
  }
}

function Sync-Runtime {
  $bundle=Read-Manifest
  $monitorSrc=Join-Path $RepoRoot 'Tools\PhoneLOL_Server_Monitor'
  $monitorDst=Join-Path $TestRoot 'monitor'
  $launcherSrc=Join-Path $RepoRoot 'Tools\PhoneLOL_Test_Launcher'
  New-Item -ItemType Directory -Force $ServerDst,$monitorDst,$RecoveryRoot,$TestRoot|Out-Null

  # Sync the pinned bundle without deleting unrelated preserved source.
  foreach($name in $bundle.Files){
    $src=Get-BundleSource $name
    if(!(Test-Path -LiteralPath $src -PathType Leaf)){throw "Runtime dependency missing in repo: $name"}
    Copy-Item -LiteralPath $src -Destination (Join-Path $ServerDst $name) -Force
  }
  Copy-Item -LiteralPath $ManifestSrc -Destination (Join-Path $ServerDst 'central_v33_runtime_files.json') -Force

  Get-ChildItem -LiteralPath $monitorSrc -File|Where-Object{$_.Extension-in@('.py','.cmd','.txt')}|ForEach-Object{
    Copy-Item -LiteralPath $_.FullName -Destination (Join-Path $monitorDst $_.Name) -Force
  }
  foreach($name in @('CENTRAL_AUTHORITY_CONTROL_V33.ps1','START_CENTRAL_AUTHORITY_SERVER_V33.ps1')){
    $src=Join-Path $launcherSrc $name
    if(!(Test-Path -LiteralPath $src -PathType Leaf)){throw "Missing launcher source: $src"}
    Copy-Item -LiteralPath $src -Destination (Join-Path $RecoveryRoot $name) -Force
  }
  # Keep this managed launcher; the legacy copy would restore obsolete server sources.
  foreach($name in @('01_START_PHONELOL.cmd','02_STATUS.cmd','03_STOP_ALL.cmd','04_OPEN_MONITOR.cmd','05_START_LOCAL_SERVER.cmd','PHONELOL_PROCESS_IDENTITY.ps1','README_TEST_FIRST.txt')){
    $src=Join-Path $launcherSrc $name
    if(Test-Path -LiteralPath $src -PathType Leaf){Copy-Item -LiteralPath $src -Destination (Join-Path $TestRoot $name) -Force}
  }
}

function Get-Listener {
  $connection=Get-NetTCPConnection -LocalPort 29000 -State Listen -ErrorAction SilentlyContinue|Select-Object -First 1
  if(!$connection){return $null}
  $process=Get-CimInstance Win32_Process -Filter "ProcessId=$($connection.OwningProcess)" -ErrorAction SilentlyContinue
  $command=[string]$process.CommandLine
  $name=if($command-match'([^\\ ]+\.py)'){[IO.Path]::GetFileName($matches[1])}else{'unknown'}
  [pscustomobject]@{Pid=$connection.OwningProcess;CommandLine=$command;Name=$name;Process=$process}
}
function Get-State {
  $listener=Get-Listener
  $server=[bool]($listener-and(Test-PhoneLolServerProcess $listener.Process $Python @($ExpectedProgram)))
  $tunnel=$false
  if(Test-Path -LiteralPath $Portwarp){
    $raw=(& $Portwarp ps --once 2>&1|Out-String)
    $tunnel=($raw-match'\blive\b'-and$raw-match[regex]::Escape([string]$PublicPort))
  }
  $apkNames=@(Get-ChildItem -LiteralPath $TestRoot -Filter '*.apk' -File -ErrorAction SilentlyContinue|Select-Object -ExpandProperty Name)
  [pscustomobject]@{
    Server=$server;Known=[bool]($listener-and(Test-PhoneLolServerProcess $listener.Process $Python $KnownPrograms));Listener=[bool]$listener;ServerName=if($listener){$listener.Name}else{'STOPPED'}
    ServerPid=if($listener){$listener.Pid}else{0};ServerCommand=if($listener){$listener.CommandLine}else{''}
    Tunnel=$tunnel;ApkNames=$apkNames
  }
}
function Show-State {
  $state=Get-State
  Write-Host '';Write-Host $LauncherVersion
  Write-Host ('Server  : '+$(if($state.Server){'READY CENTRAL V3.3'}elseif($state.Listener){'WRONG VERSION'}else{'STOPPED'}))
  if($LocalOnly){Write-Host 'Internet: DIRECT ROUTER FORWARD (tunnel not required)'}else{Write-Host ('Internet: '+$(if($state.Tunnel){'READY'}else{'STOPPED'}))}
  Write-Host 'Monitor : V3.8'
  Write-Host ('APKs    : '+$(if($state.ApkNames.Count){$state.ApkNames-join', '}else{'NONE (server can still start)'}))
  if($LocalOnly){Write-Host 'Address : 115.88.104.135:10045 -> this PC TCP 29000'}else{Write-Host "Address : $PublicHost`:$PublicPort"}
  Write-Host 'Battle  : original OPEN/DATA/UDP immediate / requested-peer FIFO'
  Write-Host 'Latency : per-peer writer / TCP_NODELAY / slow-peer isolation'
  Write-Host 'Room    : requested capacity preserved / protocol validates 1..10'
  Write-Host 'Gate    : two-player interaction user-confirmed on 1.15.6; new account/room UI awaits phone test'
  return $state
}


function Test-RuntimeCurrent {
  if(!(Test-Path -LiteralPath (Join-Path $ServerDst 'central_v33_runtime_files.json'))){return $false}
  foreach($name in (Read-Manifest).Files){
    $src=Get-BundleSource $name
    $dst=Join-Path $ServerDst $name
    if(!(Test-Path -LiteralPath $dst)){return $false}
    if((Get-FileHash -LiteralPath $src -Algorithm SHA256).Hash-ne(Get-FileHash -LiteralPath $dst -Algorithm SHA256).Hash){return $false}
  }
  return $true
}
$mutex=$null;$owned=$false
try{
 if($Action-ne'Status'){
  $mutex=New-Object Threading.Mutex($false,'Local\PhoneLOL_Server_Control_V213')
  try{$owned=$mutex.WaitOne(30000)}catch [Threading.AbandonedMutexException]{$owned=$true}
  if(!$owned){throw 'Another PhoneLOL start/stop is running. Try again after it finishes.'}
 }
 if($Action-eq'Start'){
  Test-SourceBundle
  Test-RuntimeWritable
  if(!$LocalOnly-and!(Test-Path -LiteralPath $Portwarp -PathType Leaf)){throw "Portwarp missing: $Portwarp"}
  $state=Get-State
  if($state.Listener-and!$state.Known){throw "TCP 29000 belongs to an unrecognized process; left untouched: $($state.ServerCommand)"}
  $current=$state.Server-and(Test-RuntimeCurrent)
  if(!$current){
    if($state.Listener){
      Stop-Process -Id $state.ServerPid -Force -ErrorAction Stop
      Start-Sleep -Milliseconds 500
    }
    Sync-Runtime
    if(!(Test-Path -LiteralPath $Control -PathType Leaf)){throw "Server V3.3 control missing: $Control"}
    & $Control -Action Start
  }
  if(!$LocalOnly-and!(Get-State).Tunnel){$null=& $Portwarp connect --all --save --detach 2>&1}
  $ready=$false
  for($i=0;$i-lt15;$i++){
    $state=Get-State
    $ready=$state.Server-and($LocalOnly-or$state.Tunnel)
    if($ready){break}
    Start-Sleep -Seconds 1
  }
  if(!$ready){Show-State|Out-Null;throw 'Server V3.3 did not become ready for the requested mode.'}
  if(!$NoMonitor-and(Test-Path -LiteralPath $Monitor -PathType Leaf)){
    $monitorRunning=Get-CimInstance Win32_Process -ErrorAction SilentlyContinue|Where-Object{
      $_.Name-in@('python.exe','pythonw.exe')-and$_.CommandLine-match[regex]::Escape((Join-Path $TestRoot 'monitor\phone_lol_monitor'))
    }|Select-Object -First 1
    if(!$monitorRunning){Start-Process -FilePath $Monitor -WorkingDirectory (Split-Path -Parent $Monitor)}
  }
  Show-State|Out-Null
  Write-Host ('READY - '+$(if($current){'existing V3.3 preserved; no restart.'}else{'V3.3 started.'})) -ForegroundColor Green
 }elseif($Action-eq'Stop'){
  $state=Get-State
  if($state.Listener-and!$state.Known){throw "TCP 29000 belongs to an unrecognized process; left untouched: $($state.ServerCommand)"}
  if(Test-Path -LiteralPath $Portwarp -PathType Leaf){$null=& $Portwarp stop --all 2>&1}
  if($state.Listener){Stop-Process -Id $state.ServerPid -Force -ErrorAction Stop}
  Show-State|Out-Null
 }else{
  Show-State|Out-Null
 }
}finally{
 if($owned){$mutex.ReleaseMutex()}
 if($mutex){$mutex.Dispose()}
}
