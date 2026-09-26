using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using static PhoneLOLTransport;

public static class PhoneLOLBattleTransport
{
    public static void Serve(TcpClient local, PhoneLOLServerSettings endpoint, uint device)
    {
        Central central = null;
        var outputGate = new object();
        bool handshaken = false;
        int session = 0;
        try {
            if (device == 0) throw new InvalidOperationException("Battle connection requires login.");
            central = new Central(endpoint, device);
            session = central.SessionKey;
            NetworkStream stream = local.GetStream();
            Action<ushort, int, byte[]> reply = (pid, request, payload) => {
                byte[] wire = new LegacyFrame { pid = pid, request = request, session = session, payload = payload }.Encode();
                lock (outputGate) stream.Write(wire, 0, wire.Length);
            };
            Central connection = central;
            var receiver = new Thread(() => {
                try {
                    while (true) {
                        CentralFrame incoming = connection.ReadFrame();
                        if (incoming.kind != 67) continue;
                        if (incoming.payload.Length < 6) throw new InvalidDataException("Truncated battle envelope.");
                        using (var reader = new BinaryReader(new MemoryStream(incoming.payload))) {
                            ushort pid = reader.ReadUInt16();
                            int request = reader.ReadInt32();
                            byte[] payload = reader.ReadBytes(incoming.payload.Length - 6);
                            reply(pid, request, payload);
                            if (pid < 60000) PhoneLOLRealtimeLog.Record("BATTLE_RX", "pid=" + pid + " bytes=" + payload.Length);
                        }
                    }
                } catch (Exception ex) {
                    PhoneLOLRealtimeLog.Record("BATTLE_RECEIVE_CLOSED", ex.GetType().Name + ": " + ex.Message);
                    local.Close();
                }
            }) { IsBackground = true };
            receiver.Start();
            while (true) {
                LegacyFrame frame = LegacyFrame.Read(stream);
                if (frame.pid == 60001) {
                    if (frame.payload.Length != 13 || BitConverter.ToInt32(frame.payload, 0) != 107)
                        throw new InvalidDataException("Invalid battle transport authentication.");
                    reply(frame.pid, frame.request, Body(w => {
                        w.Write((byte)0); w.Write(BitConverter.ToInt64(frame.payload, 4));
                        w.Write(DateTime.Now.Ticks); w.Write(session); w.Write(false);
                    }));
                    handshaken = true;
                    continue;
                }
                if (!handshaken) throw new InvalidDataException("Battle request before handshake.");
                if (frame.pid == 60003) { central.Send(9, new byte[0]); reply(frame.pid, frame.request, frame.payload); continue; }
                central.Send(66, Body(w => { w.Write(frame.pid); w.Write(frame.request); w.Write(frame.payload); }));
                if (frame.pid < 60000) PhoneLOLRealtimeLog.Record("BATTLE_TX", "pid=" + frame.pid + " bytes=" + frame.payload.Length);
            }
        } catch (Exception ex) {
            PhoneLOLRealtimeLog.Record("BATTLE_CONNECTION_CLOSED", ex.GetType().Name + ": " + ex.Message);
        } finally {
            if (central != null) central.Dispose();
            local.Close();
        }
    }
}
