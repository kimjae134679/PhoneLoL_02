"""Bounded untrusted phone diagnostics on the existing TCP port; never create a game peer."""
import json
import os
import re
import socket
import threading
import time

_lock = threading.Lock()
_window = 0.0
_count = 0
_secrets = re.compile(r'(?i)\b(token|password|secret|authorization|ks_pass|key_pass)\s*[:=]\s*[^\s,;]+')

def handle_if_http(connection, emit=print):
    # Peek only the first byte: game frames retain their original reader and framing.
    deadline=time.monotonic()+2
    while True:
        prefix=connection.recv(5, socket.MSG_PEEK)
        if not prefix or not (b'POST '.startswith(prefix) or b'GET /'.startswith(prefix)): return False
        if len(prefix)>=5: break
        if time.monotonic()>=deadline: return True
        time.sleep(0.005)
    global _window, _count
    with _lock:
        now=time.monotonic()
        if now-_window>=1: _window=now; _count=0
        _count+=1
        allowed=_count<=20
    connection.settimeout(2)
    status='400 Bad Request'
    try:
        header=bytearray()
        while not header.endswith(b'\r\n\r\n'):
            part=connection.recv(1)
            if not part or len(header)>=4096: raise ValueError('header')
            header.extend(part)
        lines=header.decode('ascii').split('\r\n')
        if lines[0]=='GET /phonelol-notice/v1 HTTP/1.1':
            filename=os.environ.get('PHONELOL_NOTICE_FILE',os.path.join(os.path.dirname(__file__),'lobby-notice.json'))
            try:
                if os.path.getsize(filename)>8192: raise ValueError('notice size')
                with open(filename,'r',encoding='utf-8-sig') as notice:
                    data=json.load(notice)
                headline=data.get('headline','')
                body=data.get('body','')
                if not isinstance(headline,str) or not isinstance(body,str) or len(headline)>120 or len(body)>3000:
                    raise ValueError('notice content')
                response=json.dumps({'headline':headline,'body':body},ensure_ascii=False).encode('utf-8')
            except (OSError,ValueError,TypeError,UnicodeError):
                response=b'{"headline":"","body":""}'
            connection.sendall(('HTTP/1.1 200 OK\r\nContent-Type: application/json; charset=utf-8\r\nContent-Length: '+str(len(response))+'\r\nConnection: close\r\n\r\n').encode('ascii')+response)
            return True
        if lines[0]!='POST /phonelol-diag/v1 HTTP/1.1': raise ValueError('route')
        fields={}
        for line in lines[1:]:
            if ':' in line:
                k,v=line.split(':',1); k=k.lower().strip()
                if k in fields: raise ValueError('duplicate header')
                fields[k]=v.strip()
        if 'transfer-encoding' in fields: raise ValueError('chunking')
        length=int(fields.get('content-length','0'))
        if not 0<length<=32768: raise ValueError('length')
        if not allowed: status='429 Too Many Requests'; raise ValueError('rate')
        body=bytearray()
        while len(body)<length:
            part=connection.recv(length-len(body))
            if not part: raise ValueError('truncated')
            body.extend(part)
        for line in body.decode('utf-8',errors='replace').splitlines()[:10]:
            line=_secrets.sub(lambda m:m.group(1)+'=[REDACTED]',line)
            line=''.join(c if c.isprintable() else ' ' for c in line)[:3000]
            emit('PHONE_CLIENT_TRACE trust=unverified '+line,flush=True)
        status='204 No Content'
    except (ValueError, OSError, UnicodeError):
        pass
    try: connection.sendall(('HTTP/1.1 '+status+'\r\nContent-Length: 0\r\nConnection: close\r\n\r\n').encode('ascii'))
    except OSError: pass
    return True
