// Decode a disposable-server snapshot with the original client packet readers.
EveEngine.NIFAIFOJLFI.LFJBNIDJHOM();
var probe = System.IO.File.ReadAllBytes(@"D:\A_KJ\AI\PhoneLoL_02\.git\managed-room-probe.bin");
var body = new byte[probe.Length + 4]; System.Buffer.BlockCopy(probe, 0, body, 0, probe.Length);
System.Buffer.BlockCopy(System.BitConverter.GetBytes(0x12345678u), 0, body, probe.Length, 4);
var encoded = new PhoneLOLTransport.LegacyFrame { pid=24, session=1, payload=body }.Encode();
var reader = EveEngine.PJEMPFEIOAK.PEFJOMFAOJI(); reader.LDNEFFHJNPL();
reader.HCBNCGILGEJ(encoded,0,encoded.Length); reader.HIAMPPLHDAN();
var self = new BattleServer.PBOOPPEPAIK(); reader.CAHACMKBJMI(self);
if (self.OHGOBGOIECH != 991700001 && self.OHGOBGOIECH != 991700002) throw new System.Exception("Invalid self identity");
int room=reader.PNBKOPGIHDI(); reader.KFAGPDGHEBK(); reader.KFAGPDGHEBK(); reader.KFAGPDGHEBK();
reader.ODFEGIDCMPH(); reader.JCGKFEPEJPO(); reader.KFAGPDGHEBK();
int count=0;
for (int i=0;i<6;i++) {
    if (reader.JCGKFEPEJPO()) { var player=new BattleServer.PBOOPPEPAIK(); reader.CAHACMKBJMI(player);
        if (player.GDMBDKBCNBD()!=i || player.NCHJJNGPOPA()<=0) throw new System.Exception("Invalid player slot/session"); count++; }
    reader.BMKOKHGAHEC(); reader.AFPCLLNMGJP(); reader.KFAGPDGHEBK(); reader.PNBKOPGIHDI(); reader.KFAGPDGHEBK();
    reader.CAHACMKBJMI(new GameServer.CLJOMPBCNOE());
    reader.PNBKOPGIHDI(); reader.AJPFAAFLHEB(); reader.KFAGPDGHEBK(); reader.PNBKOPGIHDI(); reader.PNBKOPGIHDI(); reader.BMKOKHGAHEC();
}
if (count!=2 || reader.BMKOKHGAHEC()!=0x12345678u) throw new System.Exception("Room layout mismatch");
reader.CDPNLMMNNBD();
return "Original decoder PASS: room="+room+", players="+count;
