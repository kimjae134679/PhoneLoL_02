// Run in isolated SampleScene Play Mode. The endpoint verifies attack dispatch, not network damage calculation.
EveEngine.NIFAIFOJLFI.LFJBNIDJHOM();
var report=new System.Text.StringBuilder();
var fixture=new UnityEngine.GameObject("Attack regression fixture");fixture.AddComponent<ActorManager>();fixture.AddComponent<GameObjectPool>();
System.Func<string,int,Actor> make=(name,id)=>{
 var go=new UnityEngine.GameObject(name);go.transform.parent=fixture.transform;go.SetActive(false);go.AddComponent<HumanSM>();var a=name=="target"?(Actor)go.AddComponent<PhoneLOLAttackProbeTarget>():go.AddComponent<Actor>();a.m_audioClips=new UnityEngine.AudioClip[0];go.SetActive(true);
 var info=new GameServer.NEFBHKKAMJF();info.FIGLEPBIEEJ((ushort)id);a.SetInfo(info);return a;
};
try{
 var owner=make("Teemo",21);var turret=make("Nexus",31000);var target=make("target",1);target.transform.position=UnityEngine.Vector3.forward*5;
 for(int i=0;i<30;i++){
  var source=i%2==0?owner:turret;var missile=source.CreateMissile("attack_missile",UnityEngine.Vector3.zero,target);
  var expected=UnityEngine.Resources.Load<UnityEngine.GameObject>("Particle/"+(i%2==0?"Teemo":"Turret")+"/attack_missile");
  if(missile.GetComponent<TargetMissileAI>().GetType()!=expected.GetComponent<TargetMissileAI>().GetType())throw new System.Exception("Mixed projectile AI");
  if(missile.GetHumanSM().get_m_owner()!=source||missile.GetHumanSM().get_m_target()!=target)throw new System.Exception("Mixed projectile ownership");
  GameObjectPool.Free(missile.gameObject);
 }
 report.AppendLine("PASS 30 alternating Teemo/Nexus shots: prefab AI, owner and target retained through pool reuse");
 int count=0;
 foreach(var path in System.IO.Directory.GetFiles("Assets/Resources/particle","attack_missile.prefab",System.IO.SearchOption.AllDirectories)){
  var prefab=UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.GameObject>(path);
  var go=GameObjectPool.Alloc(prefab,UnityEngine.Vector3.zero,UnityEngine.Quaternion.identity,g=>{
   var a=g.GetComponent<Actor>();a.InitForReuse();a.m_team=owner.m_team;var sm=g.GetComponent<HumanSM>();sm.SetOwner(owner);sm.SetTarget(target);
  });
  try{
   var ai=go.GetComponent<TargetMissileAI>();
   if(ai!=null){
    ai.Start();ai.m_damageParticleName="";ai.m_damageSoundName="";
    int before=((PhoneLOLAttackProbeTarget)target).receivedAttacks;
    ai.Attack();
    if(((PhoneLOLAttackProbeTarget)target).receivedAttacks!=before+1)throw new System.Exception("Normal hit not delivered: "+path);
    go.GetComponent<HumanSM>().SetTarget(null);ai.Attack();
    if(go.GetComponent<HumanSM>().get_m_nextState()!=StateMachine.OEOIIKMBGAG.Death)throw new System.Exception("Orphan projectile was not retired");
   }else{
    var ai2=go.GetComponent<TristanaAttackMissileAI>();
    if(ai2!=null){ai2.Start();go.GetComponent<HumanSM>().SetTarget(null);ai2.Attack();}
   }
   count++;
  }finally{UnityEngine.Object.DestroyImmediate(go);}
 }
 report.AppendLine("PASS "+count+" basic projectile prefabs: creation, normal hit delivery and missing-target cleanup (Tristana creation/cleanup only)");
 var orphan=owner.CreateMissile("attack_missile",UnityEngine.Vector3.zero,target);
 orphan.GetComponent<TargetMissileAI>().Start();orphan.GetHumanSM().SetOwner(null);orphan.GetComponent<TargetMissileAI>().Attack();
 if(orphan.GetHumanSM().get_m_nextState()!=StateMachine.OEOIIKMBGAG.Death)throw new System.Exception("Orphan owner not retired");
 report.AppendLine("PASS missing-owner cleanup");
 var guardGo=UnityEngine.Object.Instantiate(UnityEngine.Resources.Load<UnityEngine.GameObject>("practice/Alistar"),UnityEngine.Vector3.forward*2,UnityEngine.Quaternion.identity);
 guardGo.transform.parent=fixture.transform;
 var guard=guardGo.GetComponent<Actor>();var guardInfo=new GameServer.NEFBHKKAMJF();guardInfo.FIGLEPBIEEJ(1);guard.SetInfo(guardInfo);guard.m_team=1;guard.m_hp=100000;
 owner.m_team=0;owner.GetHumanSM().SetTarget(null);target.gameObject.SetActive(false);
 owner.GetHumanSM().RetargetingAttack(true,false);
 if(owner.GetHumanSM().get_m_target()!=guard)throw new System.Exception("Enemy Alistar not selected");
 guard.m_team=0;owner.GetHumanSM().RetargetingAttack(true,false);
 if(owner.GetHumanSM().get_m_target()==guard)throw new System.Exception("Friendly Alistar selected");
 guard.m_team=1;
 for(int i=0;i<3;i++){guard.m_hp=0;guard.GetHumanSM().OnEnterDeath();if((float)guard.m_hp!=100000f)throw new System.Exception("Guard did not revive");}
 report.AppendLine("PASS enemy Alistar selection, friendly exclusion, three immediate revivals");
}catch(System.Exception e){report.AppendLine("FAIL "+e);}
finally{UnityEngine.Object.DestroyImmediate(fixture);}
System.IO.File.WriteAllText("../Recovery/V171AttackVerification.txt",report.ToString());
return report.ToString();