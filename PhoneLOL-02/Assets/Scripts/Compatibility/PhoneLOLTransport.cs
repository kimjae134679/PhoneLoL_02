using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

public static class PhoneLOLTransport
{
    public static TcpClient Connect(PhoneLOLServerSettings endpoint)
    {
        var client = new TcpClient();
        try {
            var connect = client.ConnectAsync(endpoint.host, endpoint.port);
            if (!connect.Wait(6000)) throw new TimeoutException("Server connection timed out.");
            connect.GetAwaiter().GetResult();
            client.NoDelay = true;
            client.ReceiveTimeout = 8000;
            client.SendTimeout = 8000;
            return client;
        } catch { client.Close(); throw; }
    }

    public static byte[] ReadExact(Stream stream, int count)
    {
        var bytes = new byte[count];
        int offset = 0;
        while (offset < count) {
            int read = stream.Read(bytes, offset, count - offset);
            if (read == 0) throw new EndOfStreamException("Connection closed while reading a frame.");
            offset += read;
        }
        return bytes;
    }

    public static byte[] Body(Action<BinaryWriter> write)
    {
        using (var stream = new MemoryStream())
        using (var writer = new BinaryWriter(stream, Encoding.UTF8)) {
            write(writer); writer.Flush(); return stream.ToArray();
        }
    }

    public static string ReadText(BinaryReader reader)
    {
        int length = reader.ReadUInt16();
        byte[] data = reader.ReadBytes(length);
        if (data.Length != length) throw new EndOfStreamException("Truncated text.");
        return Encoding.UTF8.GetString(data);
    }

    public sealed class CentralFrame { public byte kind; public byte[] payload; }

    public sealed class Central : IDisposable
    {
        private readonly TcpClient client;
        private readonly NetworkStream stream;
        private uint peer;
        public int SessionKey { get; private set; }
        public Central(PhoneLOLServerSettings endpoint, uint device)
        {
            client = Connect(endpoint);
            stream = client.GetStream();
            try {
                Send(1, Body(w => { w.Write(4u); w.Write(0x6d674f44u); w.Write(device); }));
                byte[] hello = Receive(2);
                if (hello.Length != 16) throw new InvalidDataException("Invalid central HELLO reply.");
                peer = BitConverter.ToUInt32(hello, 0);
                SessionKey = BitConverter.ToInt32(hello, 4);
            } catch { Dispose(); throw; }
        }

        public void Send(byte kind, byte[] payload)
        {
            byte[] frame = Body(w => {
                w.Write(payload.Length + 16); w.Write(kind); w.Write((byte)0);
                w.Write((ushort)0); w.Write(0u); w.Write(peer); w.Write(payload);
            });
            stream.Write(frame, 0, frame.Length);
        }

        public CentralFrame ReadFrame()
        {
            byte[] header = ReadExact(stream, 16);
            int size = BitConverter.ToInt32(header, 0);
            if (size < 16 || size > 1048576) throw new InvalidDataException("Invalid central frame length.");
            return new CentralFrame { kind = header[4], payload = ReadExact(stream, size - 16) };
        }

        public byte[] Receive(byte expected)
        {
            // Persistent connections can queue more than 16 heartbeat frames while idle.
            var deadline = System.Diagnostics.Stopwatch.StartNew();
            while (deadline.ElapsedMilliseconds < 8000) {
                byte[] header = ReadExact(stream, 16);
                int size = BitConverter.ToInt32(header, 0);
                if (size < 16 || size > 1048576) throw new InvalidDataException("Invalid central frame length.");
                byte[] body = ReadExact(stream, size - 16);
                if (header[4] == expected) return body;
                // Protocol 4 pushes an account snapshot after HELLO.
                if (header[4] != 21 && header[4] != 10)
                    throw new InvalidDataException("Unexpected central message " + header[4]);
            }
            throw new InvalidDataException("Expected central reply was not received.");
        }

        public byte[] Account()
        {
            Send(20, new byte[0]);
            byte[] reply = Receive(21);
            if (reply.Length < 30 || reply[0] != 0)
                throw new InvalidDataException("Central account lookup was rejected.");
            return reply;
        }

        public byte[] Rpc(byte service, ushort pid, byte[] payload)
        {
            Send(64, Body(w => { w.Write(service); w.Write(pid); w.Write(payload); }));
            byte[] reply = Receive(65);
            if (reply.Length < 3 || reply[0] != service || BitConverter.ToUInt16(reply, 1) != pid)
                throw new InvalidDataException("Mismatched account RPC reply.");
            var body = new byte[reply.Length - 3];
            Buffer.BlockCopy(reply, 3, body, 0, body.Length);
            return body;
        }

        public void Dispose() { client.Close(); }
    }

    public sealed class LegacyFrame
    {
        public ushort pid;
        public int request, session;
        public byte[] payload;
        private static readonly byte[] key = MakeKey();

        private static byte[] MakeKey()
        {
            var data = new byte[16384];
            int seed = 34418;
            for (int i = 0; i < data.Length; i++) {
                seed = unchecked(seed * 1103515245 + 12345);
                data[i] = unchecked((byte)(seed / 65536 % 256));
            }
            return data;
        }

        private static void Crypt(byte[] data)
        {
            for (int i = 2; i < data.Length; i++) data[i] ^= key[(i - 2) % key.Length];
        }

        public static LegacyFrame Read(Stream stream)
        {
            byte[] prefix = ReadExact(stream, 2);
            int size = prefix[0] | prefix[1] << 8;
            if (size < 16 || size > 16384) throw new InvalidDataException("Invalid legacy frame length.");
            byte[] bytes = new byte[size];
            Buffer.BlockCopy(prefix, 0, bytes, 0, 2);
            Buffer.BlockCopy(ReadExact(stream, size - 2), 0, bytes, 2, size - 2);
            Crypt(bytes);
            int checksum = 0;
            foreach (byte b in bytes) checksum ^= b;
            if (checksum != 0) throw new InvalidDataException("Legacy frame checksum mismatch.");
            var payload = new byte[size - 16];
            Buffer.BlockCopy(bytes, 16, payload, 0, payload.Length);
            return new LegacyFrame {
                pid = BitConverter.ToUInt16(bytes, 2), request = BitConverter.ToInt32(bytes, 8),
                session = BitConverter.ToInt32(bytes, 12), payload = payload
            };
        }

        public byte[] Encode()
        {
            if (payload == null || payload.Length > 16368) throw new InvalidDataException("Legacy payload too large.");
            byte[] bytes = Body(w => {
                w.Write((ushort)(16 + payload.Length)); w.Write(pid); w.Write(0);
                w.Write(request); w.Write(session); w.Write(payload);
            });
            byte checksum = 0;
            foreach (byte b in bytes) checksum ^= b;
            bytes[4] = checksum;
            Crypt(bytes);
            return bytes;
        }
    }

    public static uint LegacyDeviceId(byte[] loginPayload)
    {
        // Recovered from stable libmght login_client_thread, addresses 0x30bc-0x3100.
        uint hash = 2166136261u;
        foreach (byte b in loginPayload) hash = unchecked((hash ^ b) * 16777619u);
        uint id = (hash & 0x3fffffffu) ^ (hash >> 16);
        return id < 10000u ? id + 10000u : id;
    }
}
