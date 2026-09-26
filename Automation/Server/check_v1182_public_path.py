"""Verify the game HELLO and PING protocol at a supplied endpoint."""
import socket
import struct
import sys
if len(sys.argv)!=3:
    raise SystemExit('usage: check_v1182_public_path.py HOST PORT')
host,port=sys.argv[1],int(sys.argv[2])
def send(sock,kind,body,peer=0):
    sock.sendall(struct.pack('<IBBHII',16+len(body),kind,0,0,0,peer)+body)
def receive(sock):
    def exact(size):
        result=b''
        while len(result)<size:
            part=sock.recv(size-len(result))
            if not part: raise ConnectionError('server closed connection')
            result+=part
        return result
    size,kind,_,_,_,peer=struct.unpack('<IBBHII',exact(16))
    return kind,peer,exact(size-16)
with socket.create_connection((host,port),timeout=8) as sock:
    sock.settimeout(8)
    send(sock,1,struct.pack('<III',4,0x6d674f44,0x7fffee01))
    kind,peer,body=receive(sock)
    assert kind==2 and len(body)==16,(kind,len(body))
    send(sock,9,b'V1182-PING',peer)
    for _ in range(4):
        kind,_,reply=receive(sock)
        if kind==10: break
    assert kind==10 and reply==b'V1182-PING',kind
    print('HELLO_OK PONG_OK')
