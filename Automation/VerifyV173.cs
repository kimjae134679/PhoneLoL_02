EveEngine.NIFAIFOJLFI.LFJBNIDJHOM();
var report = new System.Text.StringBuilder();
var flags = System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance;
var statics = System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static;
var netSingleton = typeof(NetworkManager).GetField("MLDPFDAHKHA", statics);
var eveSingleton = typeof(EveUnityNetwork).GetField("MLDPFDAHKHA", statics);
var oldNet = netSingleton.GetValue(null); var oldEve = eveSingleton.GetValue(null);
var fixture = new UnityEngine.GameObject("V173 verification"); fixture.SetActive(false);
var network = fixture.AddComponent<NetworkManager>(); netSingleton.SetValue(null, network);
var eve = fixture.AddComponent<EveUnityNetwork>(); eveSingleton.SetValue(null, eve);
System.Func<ushort, byte[], EveEngine.PJEMPFEIOAK> read = (pid, body) => {
    var wire = new PhoneLOLTransport.LegacyFrame { pid=pid, session=153285354, payload=body }.Encode();
    var reader=EveEngine.PJEMPFEIOAK.PEFJOMFAOJI(); reader.LDNEFFHJNPL();
    reader.HCBNCGILGEJ(wire,0,wire.Length); reader.HIAMPPLHDAN(); return reader;
};
System.Action<float,float,string> near = (actual, expected, label) => {
    if (UnityEngine.Mathf.Abs(actual-expected)>0.00002f) throw new System.Exception(label+": "+actual+" expected "+expected);
};
try {
    for(int c=0;c<7;c++) for(int i=0;i<2;i++) {
        var battle=new PNDMCOBIODO();
        typeof(NetworkManager).GetField("KIKKPMBKFAF",flags).SetValue(network,battle);
        typeof(EveUnityNetwork).GetField("BBAHCLDMICP",flags).SetValue(eve,battle);
        typeof(EveEngine.EKACODPEIIO).GetField("NMPLJHGLHBN",flags).SetValue(battle,153285354);
        var prefix="../.git/v173-fixtures/"+c+"-"+i+"-";
        var auth=read(1,System.IO.File.ReadAllBytes(prefix+"auth.bin"));
        try { typeof(PNDMCOBIODO).GetMethod("KGFHHIFGLCH",flags).Invoke(battle,new object[]{auth}); }
        finally { auth.CDPNLMMNNBD(); }
        if(battle.NCHJJNGPOPA()!=battle.GLPDLIDMHFA().NCHJJNGPOPA() || battle.NCHJJNGPOPA()==153285354)
            throw new System.Exception("Authenticated session was not adopted");
        var roomReader=read(24,System.IO.File.ReadAllBytes(prefix+"room.bin"));
        try { roomReader.CAHACMKBJMI(battle.IMKOGBNIJBO()); }
        finally { roomReader.CDPNLMMNNBD(); }
        for(int j=0;j<2;j++) {
            var group=read(60004,System.IO.File.ReadAllBytes(prefix+"group"+j+".bin"));
            try { typeof(EveEngine.EKACODPEIIO).GetMethod("LNHMLJJCMMH",flags).Invoke(battle,new object[]{group}); }
            finally { group.CDPNLMMNNBD(); }
        }
        var start=read(18,System.IO.File.ReadAllBytes(prefix+"start.bin"));
        try { typeof(PNDMCOBIODO).GetMethod("NKGEGAKJHLP",flags).Invoke(battle,new object[]{start}); }
        finally { start.CDPNLMMNNBD(); }
        if(battle.MKJCMHPMECO || battle.EMOCPLIJIEK || eve.IsLocalMode || eve.GetDefaultGroup()==null)
            throw new System.Exception("Actual multiplayer countdown rejected the roster");
        if(i==0) {
            bool modified=c==2 || c==6;
            if(PhoneLOLModeRules.Enabled!=modified)throw new System.Exception("Mode scope mismatch");
            near(PhoneLOLModeRules.AttackSpeed(12f),modified?12f:2.5f,"Attack speed cap");
            near(PhoneLOLModeRules.LifeSteal(2.5f),modified?2.5f:0.55f,"Lifesteal cap");
            near(PhoneLOLModeRules.CooldownReduction(1f),modified?0.712f:0.4f,"Cooldown mode scope");
            if(modified) {
                float[] input={0f,.2f,.4f,.5f,.8f,1f,1.4f,2f};
                float[] remaining={1f,.8f,.6f,.54f,.36f,.288f,.1728f,.07776f};
                for(int k=0;k<input.Length;k++)near(1f-PhoneLOLModeRules.CooldownReduction(input[k]),remaining[k],"AA image");
                float previous=0f;
                for(int k=0;k<=10000;k++) {
                    float current=PhoneLOLModeRules.CooldownReduction(k/1000f);
                    if(current<previous-0.000001f || current<0 || current>1)throw new System.Exception("Invalid cooldown progression");
                    previous=current;
                }
            }
            var rowGo=new UnityEngine.GameObject("Inactive scoreboard row"); rowGo.transform.parent=fixture.transform;
            rowGo.SetActive(false);var row=rowGo.AddComponent<UIGameMultiHeroInfo>();row.m_items=new UISprite[5];
            for(int k=0;k<5;k++){var icon=new UnityEngine.GameObject("Item"+k);icon.transform.parent=rowGo.transform;icon.transform.localPosition=UnityEngine.Vector3.right*k*50;row.m_items[k]=icon.AddComponent<UISprite>();}
            int count=modified?8:5;
            for(int k=0;k<count;k++)row.SetItemInfo(k,(ushort)(100+k));
            if(row.m_items.Length!=count)throw new System.Exception("Inactive scoreboard slots not expanded");
            for(int k=0;k<count;k++)if(row.m_items[k].get_spriteName()!=(100+k).ToString())throw new System.Exception("Missing scoreboard icon");
            UnityEngine.Object.DestroyImmediate(rowGo);
        }
        report.AppendLine("PASS actual client auth/group/countdown case="+c+" peer="+i+" session="+battle.NCHJJNGPOPA());
    }
    report.AppendLine("PASS original-mode caps; modified-mode uncapped attack speed/absorption; all AA cooldown examples and progression; inactive scoreboard slots");
    var source=System.IO.File.ReadAllText("Assets/Scripts/Assembly-CSharp/UILobbyBattleReady.cs");
    if(!source.Contains("JMHGGCGKCLE = 99f;")||!source.Contains("Mathf.CeilToInt((float)JMHGGCGKCLE)"))throw new System.Exception("Missing 99-second timer");
    report.AppendLine("PASS selection timer reset to 99, ceil display starts at 99");
}
catch(System.Exception error) { report.AppendLine("FAIL "+error); }
finally {
    typeof(PhoneLOLMultiplayerBridge).GetField("multiplayer",statics).SetValue(null,false);
    netSingleton.SetValue(null,oldNet);eveSingleton.SetValue(null,oldEve);
    UnityEngine.Object.DestroyImmediate(fixture);
}
System.IO.File.WriteAllText("../Recovery/V173ClientVerification.txt",report.ToString());
return report.ToString();