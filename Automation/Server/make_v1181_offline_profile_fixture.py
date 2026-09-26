"""Generate the recovered profile contract reference for the local solo backend."""
import sys
from pathlib import Path
sys.path.append(r'C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime\recovery\01_server_v0965_snapshot\APK')
from original_profile_contract import OriginalP4Profile, build_p4_profile
p=Path(r'D:\A_KJ\AI\PhoneLoL_02\Recovery\V1181OfflineProfileFixture.bin')
p.write_bytes(build_p4_profile(OriginalP4Profile(user_id=123456,nickname='로컬플레이어')))
print(len(p.read_bytes()))
