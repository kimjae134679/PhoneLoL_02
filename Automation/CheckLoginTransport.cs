// Narrow protocol check against a disposable account server; no gameplay or production account writes.
// Start Automation/CheckLoginServer.py first, then run this file through Unity CLI eval_file.
var configText = System.IO.File.ReadAllText(@"D:\A_KJ\AI\PhoneLoL_02\.git\login-test-endpoint.json");
var match = System.Text.RegularExpressions.Regex.Match(configText, @"""port""\s*:\s*(\d+)");
int centralPort = int.Parse(match.Groups[1].Value);
EveEngine.NIFAIFOJLFI.LFJBNIDJHOM();
byte[] OriginalFrame(ushort pid, int request, byte[] payload) {
    var packet = EveEngine.CMNIABEFLBJ.PEFJOMFAOJI();
    try {
        packet.DGFDHOLDCDL(pid); packet.ILIGMIAKIIA(request);
        packet.GBMJNFOEACC(payload);
        typeof(EveEngine.CMNIABEFLBJ).GetMethod("BCKCJLNLABI", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(packet, new object[] { true });
        var data = new byte[packet.EJGJCLHFIAM()];
        System.Buffer.BlockCopy(packet.EIMBOIKCJPE(), 0, data, 0, data.Length);
        return data;
    } finally { packet.CDPNLMMNNBD(); }
}
PhoneLOLTransport.LegacyFrame Exchange(System.Net.Sockets.NetworkStream stream, ushort pid, int request, byte[] body) {
    var bytes = OriginalFrame(pid, request, body); stream.Write(bytes, 0, bytes.Length);
    var response = PhoneLOLTransport.LegacyFrame.Read(stream);
    if (response.pid != pid || response.request != request) throw new System.Exception("Reply correlation mismatch");
    return response;
}
void Handshake(System.Net.Sockets.NetworkStream stream) {
    var body = PhoneLOLTransport.Body(w => { w.Write(107); w.Write(System.DateTime.Now.Ticks); w.Write(false); });
    var reply = Exchange(stream, 60001, 1, body);
    if (reply.payload.Length != 22 || reply.payload[0] != 0) throw new System.Exception("Handshake mismatch");
}
var endpoint = new PhoneLOLServerSettings { host = "127.0.0.1", port = centralPort };
using (var host = new PhoneLOLLocalHost(endpoint)) {
    uint uid; long token;
    using (var login = new System.Net.Sockets.TcpClient("127.0.0.1", 20000)) {
        login.ReceiveTimeout = 8000; var stream = login.GetStream(); Handshake(stream);
        var body = PhoneLOLTransport.Body(w => { w.Write(24); w.Write(new byte[16]); });
        var reply = Exchange(stream, 1, 2, body);
        if (reply.payload.Length != 13 || reply.payload[0] != 0) throw new System.Exception("Login failed");
        uid = System.BitConverter.ToUInt32(reply.payload, 1);
        token = System.BitConverter.ToInt64(reply.payload, 5);
        if (uid != PhoneLOLTransport.LegacyDeviceId(body)) throw new System.Exception("Identity changed");
    }
    using (var game = new System.Net.Sockets.TcpClient("127.0.0.1", 20001)) {
        game.ReceiveTimeout = 8000; var stream = game.GetStream(); Handshake(stream);
        var reply = Exchange(stream, 1, 3, PhoneLOLTransport.Body(w => { w.Write(160); w.Write(uid); w.Write(token); }));
        if (reply.payload[0] != 0) throw new System.Exception("Game auth failed");
        var profile = Exchange(stream, 4, 4, new byte[] { 1, 0, 0, 0, 0 });
        var runes = PhoneLOLTransport.LegacyFrame.Read(stream);
        var ready = PhoneLOLTransport.LegacyFrame.Read(stream);
        if (profile.payload[0] != 0 || System.BitConverter.ToUInt32(profile.payload, 1) != uid ||
            runes.pid != 7 || runes.payload.Length < 122 || ready.pid != 12 || ready.payload.Length != 2)
            throw new System.Exception("Profile/runes/ready bootstrap mismatch");
        // Decode the new encoder with the original recovered packet reader.
        var encoded = profile.Encode();
        var original = EveEngine.PJEMPFEIOAK.PEFJOMFAOJI();
        try {
            original.LDNEFFHJNPL(); original.HCBNCGILGEJ(encoded, 0, encoded.Length); original.HIAMPPLHDAN();
            if (original.KCGNKBDGONC() != 4 || original.KFAGPDGHEBK() != 0 || original.PNBKOPGIHDI() != (int)uid)
                throw new System.Exception("Original packet reader rejected new frame");
        } finally { original.CDPNLMMNNBD(); }
    }
}
return "PASS: original encrypted wire, real central account reply, service authentication, profile/runes/ready ordering. Disposable DB only.";
