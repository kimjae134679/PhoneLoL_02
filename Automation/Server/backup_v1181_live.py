"""Create a consistent read-only SQLite backup before the 1.18.1 server swap."""
from datetime import datetime
from pathlib import Path
import sqlite3, shutil
root=Path(r'C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime\recovery')
bundle=root/'01_server_v0965_snapshot'/'APK'
snapshot=root/'04_runtime'/'backups'/('v1181_'+datetime.now().strftime('%Y%m%d_%H%M%S'))
snapshot.mkdir(parents=True,exist_ok=False)
source=root/'04_runtime'/'data'/'multigod-central-authority-v2.db'
with sqlite3.connect('file:'+source.as_posix()+'?mode=ro',uri=True) as live:
 with sqlite3.connect(snapshot/'multigod-central-authority-v2.db') as backup: live.backup(backup)
for name in ('account_services_v1158.py','managed_results_v1168.py'):
 shutil.copy2(bundle/name,snapshot/name)
with sqlite3.connect(snapshot/'multigod-central-authority-v2.db') as backup:
 assert backup.execute('PRAGMA integrity_check').fetchone()[0]=='ok'
 print('BACKUP',snapshot,'ACCOUNTS',backup.execute('SELECT count(*) FROM accounts').fetchone()[0])
