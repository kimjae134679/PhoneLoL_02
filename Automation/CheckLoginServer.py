import sys, tempfile, json, os
# This fixture always uses a disposable database, never the live account store.
from pathlib import Path
sys.path.insert(0, r"D:\A_KJ\AI\PhoneLOL\APK")
import server_central_authority_v33 as server
with tempfile.TemporaryDirectory(prefix="phonelol-v1165-") as temp:
    instance = server.build_server("127.0.0.1", 0, str(Path(temp) / "accounts.db"))
    (Path(__file__).resolve().parents[1] / ".git/login-test-endpoint.json").write_text(json.dumps({"port": instance.server_address[1], "pid": os.getpid()}))
    print("TEMPORARY_SERVER_READY", flush=True)
    instance.serve_forever()
