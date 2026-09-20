using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using static PhoneLOLTransport;

public sealed class PhoneLOLLocalHost : IDisposable
{
    private sealed class AccountSession { public long token; public DateTime expires; }
    private readonly Dictionary<uint, AccountSession> accounts = new Dictionary<uint, AccountSession>();
    private readonly List<TcpListener> listeners = new List<TcpListener>();
    private readonly HashSet<TcpClient> clients = new HashSet<TcpClient>();
    private readonly object gate = new object();
    private readonly PhoneLOLServerSettings endpoint;
    private volatile bool stopped;
    private int nextSession;

    public PhoneLOLLocalHost(PhoneLOLServerSettings endpoint)
    {
        this.endpoint = endpoint;
        try {
            foreach (int port in new[] { 20000, 20001, 20100 }) {
                var listener = new TcpListener(IPAddress.Loopback, port);
                listener.Start(8);
                listeners.Add(listener);
                var thread = new Thread(() => Accept(listener, port)) { IsBackground = true };
                thread.Start();
            }
            PhoneLOLRealtimeLog.Record("HOST_READY", "login=20000 game=20001 community=20100 central=" + endpoint);
        } catch { Dispose(); throw; }
    }

    private void Accept(TcpListener listener, int port)
    {
        while (!stopped) {
            try {
                var client = listener.AcceptTcpClient();
                client.NoDelay = true; client.ReceiveTimeout = 60000; client.SendTimeout = 8000;
                lock (gate) {
                    if (stopped || clients.Count >= 8) { client.Close(); continue; }
                    clients.Add(client);
                }
                ThreadPool.QueueUserWorkItem(_ => Serve(client, port));
            } catch (Exception ex) {
                if (!stopped) PhoneLOLRealtimeLog.Record("HOST_ACCEPT_FAILED", ex.ToString());
                return;
            }
        }
    }

    private void Serve(TcpClient client, int port)
    {
        int session = Interlocked.Increment(ref nextSession);
        uint device = 0;
        bool authorized = false, handshaken = false;
        try {
            using (client)
            using (var stream = client.GetStream()) {
                while (!stopped) {
                    LegacyFrame frame = LegacyFrame.Read(stream);
                    PhoneLOLRealtimeLog.Record("LOCAL_RX", "port=" + port + " session=" + session + " pid=" + frame.pid + " bytes=" + frame.payload.Length);
                    if (frame.pid == 60001) {
                        if (frame.payload.Length != 13 || BitConverter.ToInt32(frame.payload, 0) != 107)
                            throw new InvalidDataException("Unsupported local transport version.");
                        Reply(stream, session, frame, Body(w => {
                            w.Write((byte)0); w.Write(BitConverter.ToInt64(frame.payload, 4));
                            w.Write(DateTime.Now.Ticks); w.Write(session); w.Write(false);
                        }));
                        handshaken = true;
                        continue;
                    }
                    if (!handshaken) throw new InvalidDataException("Application packet before transport authentication.");
                    if (frame.pid == 60003) { Reply(stream, session, frame, frame.payload); continue; }
                    if (port == 20000) {
                        if (frame.pid != 1 || frame.payload.Length < 10 || BitConverter.ToInt32(frame.payload, 0) != 24)
                            throw new InvalidDataException("Invalid login request.");
                        device = LegacyDeviceId(frame.payload);
                        using (var central = new Central(endpoint, device)) {
                            byte[] account = central.Account();
                            long token = BitConverter.ToInt64(account, 5);
                            if (token == 0) throw new InvalidDataException("Central account has no authentication token.");
                            lock (gate) accounts[device] = new AccountSession { token = token, expires = DateTime.UtcNow.AddHours(12) };
                            Reply(stream, session, frame, Body(w => { w.Write((byte)0); w.Write(device); w.Write(token); }));
                        }
                        PhoneLOLRealtimeLog.Record("LOGIN_ACCEPTED", "session=" + session + " identity=legacy-fnv");
                        continue;
                    }
                    if (frame.pid == 1) {
                        if (frame.payload.Length < 16 || BitConverter.ToInt32(frame.payload, 0) != (port == 20001 ? 160 : 13))
                            throw new InvalidDataException("Invalid service login.");
                        device = BitConverter.ToUInt32(frame.payload, 4);
                        long token = BitConverter.ToInt64(frame.payload, 8);
                        lock (gate) {
                            AccountSession value;
                            authorized = accounts.TryGetValue(device, out value) && value.token == token && value.expires > DateTime.UtcNow;
                        }
                        if (!authorized) throw new InvalidDataException("Service authentication has no matching login session.");
                        using (var central = new Central(endpoint, device)) {
                            byte[] account = central.Account();
                            if (BitConverter.ToInt64(account, 5) != token)
                                throw new InvalidDataException("Central account authentication changed.");
                            if (port == 20001) Reply(stream, session, frame, new byte[] { 0 });
                            else Community(stream, session, frame, central);
                        }
                        continue;
                    }
                    if (!authorized) throw new InvalidDataException("Request before service login.");
                    using (var central = new Central(endpoint, device)) {
                        if (port == 20001) Game(stream, session, frame, central);
                        else Community(stream, session, frame, central);
                    }
                }
            }
        } catch (EndOfStreamException) {
            PhoneLOLRealtimeLog.Record("LOCAL_CLOSED", "port=" + port + " session=" + session);
        } catch (Exception ex) {
            if (!stopped) PhoneLOLRealtimeLog.Record("SERVICE_FAILED", "port=" + port + " session=" + session + " endpoint=" + endpoint + " " + ex);
        } finally {
            client.Close();
            lock (gate) clients.Remove(client);
        }
    }

    private static byte[] LegacyRuneImport(byte[] payload)
    {
        if (payload.Length == 0) return new byte[0];
        using (var reader = new BinaryReader(new MemoryStream(payload))) {
            reader.ReadByte(); ReadText(reader); ReadText(reader);
            int remaining = (int)(reader.BaseStream.Length - reader.BaseStream.Position);
            if (remaining != 0 && remaining != 120) throw new InvalidDataException("Invalid legacy rune migration.");
            return reader.ReadBytes(remaining);
        }
    }

    private static void Game(NetworkStream stream, int session, LegacyFrame frame, Central central)
    {
        if (frame.pid == 4) {
            byte[] profile = central.Rpc(0, 4, frame.payload);
            if (profile.Length < 103 || profile[0] != 0) throw new InvalidDataException("Profile was rejected.");
            byte[] runes = central.Rpc(0, 7, LegacyRuneImport(frame.payload));
            if (runes.Length < 122 || BitConverter.ToUInt16(runes, 0) * 6 + 122 != runes.Length)
                throw new InvalidDataException("Invalid rune inventory.");
            // Preserve the stable native host's profile -> inventory -> login-ready ordering.
            Reply(stream, session, frame, profile);
            Reply(stream, session, new LegacyFrame { pid = 7 }, runes);
            Reply(stream, session, new LegacyFrame { pid = 12 }, new byte[] { 0, 0 });
            PhoneLOLRealtimeLog.Record("GAME_BOOTSTRAP_SENT", "profile=4 runes=7 ready=12 session=" + session);
            return;
        }
        if (frame.pid == 3) {
            central.Send(9, new byte[0]); central.Receive(10);
            Reply(stream, session, frame, Body(w => { w.Write(false); w.Write(0); }));
            return;
        }
        if (frame.pid == 7 || frame.pid == 17 || frame.pid == 38 || frame.pid == 39 || frame.pid == 40) {
            byte[] response = central.Rpc(0, frame.pid, frame.payload);
            if (response.Length == 0 || response[0] == 255) throw new InvalidDataException("Account request rejected: " + frame.pid);
            Reply(stream, session, frame, response);
            return;
        }
        // Battle room translation must be recovered separately; never return invented success.
        throw new NotSupportedException("Legacy game message is not yet migrated: " + frame.pid);
    }

    private static void Community(NetworkStream stream, int session, LegacyFrame frame, Central central)
    {
        if (frame.pid == 6) throw new NotSupportedException("Room invitation context requires the battle host.");
        byte[] reply = central.Rpc(1, frame.pid, frame.payload);
        if (reply.Length == 1 && reply[0] == 255) throw new InvalidDataException("Community request rejected.");
        if (reply.Length > 0) Reply(stream, session, frame, reply);
        if (frame.pid == 1 || frame.pid == 3 || frame.pid == 8 || frame.pid == 9 || frame.pid == 10 || frame.pid == 11) {
            byte[] friends = central.Rpc(1, 4, new byte[0]);
            if (friends.Length < 4) throw new InvalidDataException("Invalid friend roster.");
            Reply(stream, session, new LegacyFrame { pid = 4 }, friends);
        }
        byte[] events = central.Rpc(2, 0, new byte[0]);
        using (var reader = new BinaryReader(new MemoryStream(events))) {
            int count = reader.ReadUInt16();
            if (count > 32) throw new InvalidDataException("Invalid community event count.");
            for (int i = 0; i < count; i++) {
                ushort pid = reader.ReadUInt16(), size = reader.ReadUInt16();
                byte[] body = reader.ReadBytes(size);
                if (body.Length != size) throw new EndOfStreamException("Truncated community event.");
                if (pid == 13 || pid == 7 || pid == 5) Reply(stream, session, new LegacyFrame { pid = pid }, body);
            }
        }
    }

    private static void Reply(NetworkStream stream, int session, LegacyFrame request, byte[] body)
    {
        byte[] wire = new LegacyFrame { pid = request.pid, request = request.request, session = session, payload = body }.Encode();
        stream.Write(wire, 0, wire.Length);
        PhoneLOLRealtimeLog.Record("LOCAL_TX", "session=" + session + " pid=" + request.pid + " bytes=" + body.Length);
    }

    public void Dispose()
    {
        stopped = true;
        foreach (var listener in listeners) listener.Stop();
        lock (gate) {
            foreach (var client in clients) client.Close();
            accounts.Clear();
        }
    }
}
