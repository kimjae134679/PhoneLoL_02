$ErrorActionPreference='Stop'
$source='D:\A_KJ\AI\PhoneLoL_02\Automation\Server'
$recovery='C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime\recovery'
$target=Join-Path $recovery '01_server_v0965_snapshot\APK'
$players=@(Get-NetTCPConnection -LocalPort 29000 -State Established -ErrorAction SilentlyContinue)
if($players.Count -gt 0){throw 'Server has active users; postpone restart.'}
foreach($name in @('account_services_v1158.py','managed_results_v1168.py')){
 Copy-Item -LiteralPath (Join-Path $source $name) -Destination (Join-Path $target $name) -Force
}
$running=Get-CimInstance Win32_Process | Where-Object {$_.Name -eq 'python.exe' -and $_.CommandLine -like '*server_central_authority_v33.py*'}
if(@($running).Count -ne 1){throw 'Expected exactly one central server process.'}
Stop-Process -Id $running.ProcessId -Force
Start-Sleep -Seconds 2
$startup=Join-Path $recovery 'START_CENTRAL_AUTHORITY_SERVER_V33.ps1'
$started=Start-Process powershell.exe -ArgumentList ('-NoProfile -ExecutionPolicy Bypass -File "'+$startup+'"') -WindowStyle Hidden -PassThru
for($try=0;$try -lt 30;$try++){
 Start-Sleep -Seconds 1
 $listen=Get-NetTCPConnection -LocalPort 29000 -State Listen -ErrorAction SilentlyContinue
 if($listen){Write-Output ('SERVER_READY port=29000 process='+$listen.OwningProcess+' runner='+$started.Id);exit 0}
}
throw 'Central server failed to listen within 30 seconds.'
