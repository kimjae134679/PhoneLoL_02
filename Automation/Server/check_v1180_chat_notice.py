"""Disposable chat and notice checks for 1.18.0."""
import json, os, pathlib, socket, struct, tempfile, threading
from check_managed_v1167 import Client, server, core
import phone_http_diagnostics as notice
def test():
    with tempfile.TemporaryDirectory() as tmp:
        db = str(pathlib.Path(tmp) / "accounts.db")
        srv = server.build_server("127.0.0.1", 0, db)
        threading.Thread(target=srv.serve_forever, daemon=True).start()
        a = Client(srv.server_address[1], 991800001)
        b = Client(srv.server_address[1], 991800002)
        try:
            assert a.rpc(0, 17, core.encode_text("Author180"))[0] == 0
            assert a.rpc(3, 2, core.encode_text("Hello everyone"))[0] == 0
            assert a.rpc(3, 2, core.encode_text("Flood"))[0] != 0
            history = b.rpc(3, 1, struct.pack("<II", 0, 0))
            assert history[0] == 0 and struct.unpack_from("<H", history, 1)[0] == 1
            assert b"Author180" in history and b"Hello everyone" in history
            print("PASS public chat author, second account, rate limit")
            store = srv.state.account_services.store
            with store._lock, store._db:
                for i in range(120):
                    store._db.execute("INSERT INTO public_chat(sender_uid,nickname,message,created_at) VALUES(?,?,?,?)", (srv.state.account_services.account(a.device).uid, "Author180", "history-"+str(i), 1234567890))
            newest = b.rpc(3, 1, struct.pack("<II", 0, 0))
            assert struct.unpack_from("<H", newest, 1)[0] == 50
            before = struct.unpack_from("<I", newest, 3)[0]
            middle = b.rpc(3, 1, struct.pack("<II", before, 0))
            assert struct.unpack_from("<H", middle, 1)[0] == 50
            before = struct.unpack_from("<I", middle, 3)[0]
            oldest = b.rpc(3, 1, struct.pack("<II", before, 0))
            assert struct.unpack_from("<H", oldest, 1)[0] == 21
            print("PASS public chat 50-item pagination covers all 121 messages")
        finally:
            a.s.close(); b.s.close(); srv.shutdown(); srv.server_close()
        srv = server.build_server("127.0.0.1", 0, db)
        threading.Thread(target=srv.serve_forever, daemon=True).start()
        c = Client(srv.server_address[1], 991800002)
        try:
            assert b"history-119" in c.rpc(3, 1, struct.pack("<II", 0, 0))
            print("PASS chat persisted after server restart")
        finally:
            c.s.close(); srv.shutdown(); srv.server_close()
        path = pathlib.Path(tmp) / "lobby-notice.json"
        path.write_text(json.dumps({"headline": "Maintenance", "body": "Tonight 8pm"}), encoding="utf-8")
        previous = os.environ.get("PHONELOL_NOTICE_FILE")
        os.environ["PHONELOL_NOTICE_FILE"] = str(path)
        try:
            left, right = socket.socketpair()
            right.sendall(b"GET /phonelol-notice/v1 HTTP/1.1\r\nHost: localhost\r\n\r\n")
            assert notice.handle_if_http(left)
            body = right.recv(4096)
            assert b"Maintenance" in body and b"Tonight 8pm" in body
            left.close(); right.close()
            print("PASS editable lobby notice HTTP endpoint")
        finally:
            if previous is None: os.environ.pop("PHONELOL_NOTICE_FILE", None)
            else: os.environ["PHONELOL_NOTICE_FILE"] = previous
if __name__ == "__main__": test()
