using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using UnityEngine;
using static PhoneLOLTransport;

// A single-player transport that stays on the device when the central server is unavailable.
// Its data is session-local and never writes ranked matches or online account records.
public static class PhoneLOLOfflineSession
{
    private static int failurePending;
    public static bool Enabled { get; private set; }
    public static void ReportConnectionFailure() {
        if (!Enabled) Interlocked.CompareExchange(ref failurePending, 1, 0);
    }
    public static bool ConsumeConnectionFailure() {
        return Interlocked.CompareExchange(ref failurePending, 2, 1) == 1 && !Enabled;
    }
    private static string cachedName = "로컬플레이어", pendingName;
    public static void Enable() {
        cachedName = PlayerPrefs.GetString("PhoneLOL.OfflineName", "로컬플레이어");
        Enabled = true; Interlocked.Exchange(ref failurePending, 2);
    }
    public static void Disable() { Enabled = false; Interlocked.Exchange(ref failurePending, 0); }
    public static void SaveProfileOnMainThread() {
        string name;
        lock (gate) { name = pendingName; pendingName = null; }
        if (name == null) return;
        PlayerPrefs.SetString("PhoneLOL.OfflineName", name); PlayerPrefs.Save();
    }

    private static readonly object gate = new object();
    private static readonly Dictionary<uint, SoloPlayer> players = new Dictionary<uint, SoloPlayer>();
    private sealed class SoloPlayer {
        internal uint device; internal string nickname; internal byte mode = 10;
        internal ushort hero; internal byte skin, ready, lane, slot;
        internal ulong game = 118100001; internal int session = 1;
        internal bool worldReady; internal DateTime startedUtc; internal byte[] result;
    }
    private static SoloPlayer Player(uint device) {
        lock (gate) {
            SoloPlayer player;
            if (!players.TryGetValue(device, out player)) {
                player = new SoloPlayer { device = device,
                    nickname = cachedName };
                players.Add(device, player);
            }
            return player;
        }
    }
    private static void WriteText(BinaryWriter writer, string value) {
        byte[] bytes = Encoding.UTF8.GetBytes(value);
        writer.Write((ushort)bytes.Length); writer.Write(bytes);
    }
    public sealed class Endpoint : IDisposable
    {
        private readonly SoloPlayer player;
        private readonly BlockingCollection<CentralFrame> replies = new BlockingCollection<CentralFrame>();
        public int SessionKey { get { return player.session; } }
        public Endpoint(uint device) { player = Player(device); }
        private void Reply(ushort pid, int request, byte[] body) {
            replies.Add(new CentralFrame { kind = 67, payload = Body(w => {
                w.Write(pid); w.Write(request); w.Write(body);
            }) });
        }
        public CentralFrame ReadFrame() { return replies.Take(); }
        public byte[] Account() {
            return Body(w => {
                w.Write((byte)0); w.Write((int)player.device); w.Write((long)118100001);
                w.Write((byte)99); w.Write(100000000); w.Write(0); w.Write((ushort)0);
                w.Write(0u); WriteText(w, player.nickname);
            });
        }
        public byte[] Receive(byte kind) {
            if (kind == 2) return Body(w => { w.Write(1001u); w.Write(1); w.Write(118100001L); });
            if (kind == 10) return new byte[0];
            if (kind == 51) {
                byte[] owned = OwnedHeroes();
                return Body(w => { w.Write((byte)0); w.Write((ushort)owned.Length);
                    w.Write((ushort)0); w.Write(owned); });
            }
            throw new InvalidDataException("Unsupported offline message " + kind);
        }
        public void Send(byte kind, byte[] payload) {
            if (kind == 66) {
                if (payload.Length < 6) throw new InvalidDataException("Truncated offline battle packet");
                ushort pid = BitConverter.ToUInt16(payload, 0);
                int request = BitConverter.ToInt32(payload, 2);
                byte[] body = new byte[payload.Length - 6];
                Buffer.BlockCopy(payload, 6, body, 0, body.Length);
                Battle(pid, request, body);
            }
        }
        public byte[] Rpc(byte service, ushort pid, byte[] payload) {
            if (service == 0) return Game(pid, payload);
            if (service == 1) return Community(pid, payload);
            if (service == 2) return new byte[2]; // No pending community events.
            if (service == 3) return new byte[] { 255 }; // No global chat offline.
            return new byte[] { 255 };
        }
        private byte[] Game(ushort pid, byte[] payload) {
            switch (pid) {
                case 4: return Profile();
                case 7: return RuneInventory();
                case 5: return OwnedHeroes();
                case 25:
                    if (payload.Length < 2) return new byte[] { 1 };
                    player.mode = payload[0];
                    return Body(w => { w.Write((byte)0); w.Write(player.mode);
                        w.Write(payload[1]); w.Write((int)player.mode);
                        w.Write(0x11670001); w.Write(new byte[] { 127,0,0,1 });
                        w.Write((ushort)20002); });
                case 17:
                    if (payload.Length < 2) return new byte[] { 3 };
                    int size = BitConverter.ToUInt16(payload, 0);
                    if (size != payload.Length - 2 || size > 48) return new byte[] { 3 };
                    player.nickname = Encoding.UTF8.GetString(payload, 2, size);
                    lock (gate) pendingName = player.nickname;
                    return Body(w => { w.Write((byte)0); WriteText(w, player.nickname);
                        w.Write(100000000L); w.Write(0L); });
                case 3: return new byte[] { 0 };
                case 27: return LookupResult(payload);
                case 33: return Body(w => w.Write((ushort)0));
                default: return new byte[] { 255 };
            }
        }
        private byte[] Community(ushort pid, byte[] payload) {
            if (pid == 1) return Body(w => {
                w.Write((byte)0); w.Write(player.device); WriteText(w,player.nickname);
                w.Write((byte)99); w.Write((byte)0); w.Write((byte)0);
                w.Write(0u); w.Write(0); w.Write(100000000L); w.Write(0);
                w.Write(0u); w.Write((byte)0); w.Write(0u); w.Write(0u);
                w.Write((byte)0);
            });
            if (pid == 3) return Body(w => { w.Write((byte)0); w.Write(0); });
            if (pid == 4) return new byte[4];
            if (pid == 5) return new byte[0];
            return new byte[] { 0 };
        }
        private byte[] Profile() {
            return Body(w => {
                w.Write((byte)0); w.Write(player.device); WriteText(w,player.nickname);
                w.Write((byte)99); w.Write((byte)0); w.Write((byte)0); w.Write((byte)0);
                w.Write(0u); w.Write(0u); w.Write(100000000L); w.Write(0);
                w.Write(0u); w.Write(0); w.Write(0u); w.Write(0);
                w.Write((byte)0); w.Write(0L); w.Write((byte)0); w.Write(0L);
                for (int i=0;i<4;i++) w.Write(0u);
                w.Write((ushort)0); w.Write((byte)0); w.Write(0L);
                w.Write((byte)0); w.Write((byte)0); w.Write(0L); w.Write(false);
            });
        }
        private static byte[] OwnedHeroes() {
            return Body(w => {
                w.Write((ushort)27);
                for (ushort hero=1;hero<=27;hero++) {
                    w.Write(hero); WriteText(w, ""); w.Write((byte)1);
                    w.Write((byte)0); w.Write((byte)1);
                }
            });
        }
        private static byte[] RuneInventory() {
            return Body(w => {
                w.Write((ushort)58);
                for (ushort id=13001;id<=13014;id++) { w.Write(id); w.Write(9u); }
                for (ushort id=23001;id<=23014;id++) { w.Write(id); w.Write(9u); }
                for (ushort id=33001;id<=33014;id++) { w.Write(id); w.Write(9u); }
                for (ushort id=43001;id<=43016;id++) { w.Write(id); w.Write(3u); }
                for (int slot=0;slot<60;slot++) w.Write((ushort)0);
            });
        }
        private byte[] LookupResult(byte[] payload) {
            if (payload.Length != 19 || BitConverter.ToUInt64(payload, 0) != player.game ||
                BitConverter.ToUInt16(payload, 8) != player.hero) return new byte[] { 255 };
            lock (gate) return player.result ?? new byte[] { 255 };
        }
        private byte[] MatchResult() {
            int seconds = (int)Math.Min(int.MaxValue, Math.Max(1, (DateTime.UtcNow - player.startedUtc).TotalSeconds));
            return Body(w => {
                w.Write(seconds); w.Write(0u); w.Write(0L); w.Write(0L); w.Write((byte)0);
                w.Write((byte)99); w.Write(0u); w.Write(100000000L);
                for (int i = 0; i < 4; i++) w.Write(0u);
                for (int i = 0; i < 2; i++) { w.Write((byte)0); w.Write(0); w.Write(0u); }
                w.Write(0); w.Write((byte)0); w.Write(DateTime.UtcNow.Ticks);
            });
        }
        private byte[] PlayerInfo() {
            return Body(w => {
                w.Write(player.device); WriteText(w,player.nickname); w.Write((byte)99);
                w.Write(player.session); w.Write((byte)(player.slot % 2));
                w.Write(player.hero); w.Write(player.skin);
                w.Write(player.slot); w.Write(player.ready); w.Write(player.lane);
                w.Write(0u); w.Write((byte)0); w.Write(0u);
            });
        }
        private byte[] Roster() {
            return Body(w => {
                w.Write(5001); w.Write((byte)1);
                w.Write((byte)(player.mode == 20 ? 2 : player.mode >= 101 ? 10 : 6));
                w.Write(player.slot); w.Write(player.game);
                w.Write((byte)1); w.Write(player.mode);
                int slots = player.mode == 20 ? 6 : player.mode >= 101 ? 10 : 6;
                for (byte slot=0;slot<slots;slot++) {
                    bool occupied=slot==player.slot; w.Write(occupied);
                    if (occupied) w.Write(PlayerInfo());
                    w.Write(occupied ? player.device : 0u);
                    WriteText(w,occupied ? player.nickname : "");
                    w.Write(occupied ? (byte)99 : (byte)0); w.Write(0); w.Write((byte)0);
                    w.Write((ushort)0); w.Write((byte)0); w.Write((byte)0);
                    w.Write((ushort)0); w.Write((byte)1);
                    for (int stat=0;stat<28;stat++) w.Write(0f);
                    w.Write(0);
                    w.Write(0u); w.Write(occupied ? player.hero : (ushort)0);
                    w.Write(occupied ? player.skin : (byte)0);
                    w.Write(occupied ? (player.session+1)*1000+1 : 0);
                    w.Write(occupied ? player.session : 0); w.Write(0u);
                }
            });
        }
        private void Publish(bool first) {
            var roster=Roster();var self=PlayerInfo();
            Reply(24,0,Body(w=>{ w.Write(self); w.Write(roster); }));
            if (first) Reply(7,0,Body(w=>{ w.Write((byte)0);
                w.Write((byte)(player.slot%2)); w.Write(player.lane); w.Write(roster); }));
        }
        private void StartBattle() {
            player.startedUtc = DateTime.UtcNow; player.worldReady = false;
            lock (gate) player.result = null;
            byte[] endpoint={127,0,0,1,0x22,0x4e}; // 20002 little endian
            Reply(60004,0,Body(w=>{w.Write(5001);w.Write(player.session);
                w.Write(player.session); w.Write(endpoint);w.Write(endpoint);}));
            Reply(18,0,Body(w=>{
                w.Write((byte)1);
                int slots=player.mode>=101?10:6;
                for (int i=0;i<slots;i++) {
                    bool mine=i==player.slot;
                    w.Write(mine?player.hero:(ushort)0);w.Write(mine?player.skin:(byte)0);
                    w.Write(mine?(player.session+1)*1000+1:0);
                    w.Write(mine?player.session:0);
                }
            }));
        }
        private void Battle(ushort pid,int request,byte[] data) {
            switch(pid) {
                case 1: Reply(pid,request,Body(w=>{w.Write((byte)0);
                    w.Write(PlayerInfo());w.Write(-1);}));break;
                case 3: Reply(pid,request,new byte[]{0});break;
                case 4: case 5: case 8:
                    player.hero=0;player.ready=0;player.slot=0;
                    Publish(true);break;
                case 12:
                    if(data.Length==2) { player.hero=BitConverter.ToUInt16(data,0);
                        player.skin=0;Publish(false); } break;
                case 13:
                    if(data.Length==1) { player.skin=data[0];Publish(false); }break;
                case 14:
                    if(data.Length==1) { player.lane=data[0];Publish(false); }break;
                case 16:
                    player.ready=(byte)(player.ready==0?1:0);
                    Publish(false);
                    if(player.ready==1 && player.hero>=1 && player.hero<=27)StartBattle();
                    break;
                case 19:
                    Reply(19,0,Body(w=>{w.Write(player.device);w.Write(data);}));
                    Reply(20,0,Body(w=>{w.Write(true);w.Write(player.game);}));
                    break;
                case 21: player.worldReady = true; break;
                case 22:
                    if (!player.worldReady || data.Length < 9 || data[0] > 2) {
                        Reply(22,request,new byte[]{255}); break;
                    }
                    lock (gate) player.result = MatchResult();
                    Reply(22,request,data); break;
                case 60019: break; // Eve handles the sole local player in IsLocalMode.
                case 10: Reply(10,request,Body(w=>{w.Write((byte)0);
                    w.Write(player.device);w.Write(false);}));break;
                default: Reply(pid,request,new byte[]{255});break;
            }
        }
        public void Dispose() { replies.CompleteAdding(); }
    }
}
