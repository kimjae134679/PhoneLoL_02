"""Check ranked and whole-account match counts with mixed mode and draw fixtures."""
import sqlite3
import threading
from types import SimpleNamespace
import sys
sys.path.append( r'C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime\recovery\01_server_v0965_snapshot\APK')
from managed_results_v1168 import ManagedResults

db=sqlite3.connect(':memory:')
store=SimpleNamespace(_db=db,_lock=threading.RLock())
results=ManagedResults(store)
for uid in (1,2): db.execute('INSERT INTO managed_rank_stats(uid,mode,points,wins,losses) VALUES(?,?,?,?,?)',(uid,0,1000,2 if uid==1 else 0,1 if uid==1 else 0))
for game,mode,winner,competitive,slot in (('ranked',10,0,1,0),('normal',100,1,0,0),('urf',103,0,0,0),('draw',102,2,0,0),('opposite',20,1,1,1)):
 db.execute('INSERT INTO managed_match_results VALUES(?,?,?,?,?,?,?)',(game,mode,winner,500,1000,competitive,b'fixture'))
 db.execute('INSERT INTO managed_match_members VALUES(?,?,?,?)',(game,1,21,slot))
assert results.all_match_counts(1)==(3,1),results.all_match_counts(1)
assert results.all_match_counts(2)==(0,0)
assert results.stats(1)[0][1:3]==(2,1)
print('PASS all matches 3 wins 1 loss, draws excluded, ranked stats unchanged, no matches 0/0')
