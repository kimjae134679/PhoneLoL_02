try {
EveEngine.NIFAIFOJLFI.LFJBNIDJHOM();
var report=new System.Text.StringBuilder();var flags=System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance;
var statics=System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Static;
var root=new UnityEngine.GameObject("V174 animation fixture");
var netGo=new UnityEngine.GameObject("inactive network");netGo.transform.parent=root.transform;netGo.SetActive(false);
var net=netGo.AddComponent<NetworkManager>();var nf=typeof(NetworkManager).GetField("MLDPFDAHKHA",statics);var oldNet=nf.GetValue(null);nf.SetValue(null,net);
var eve=root.AddComponent<EveUnityNetwork>();var battle=new PNDMCOBIODO();battle.IMKOGBNIJBO().EHCPMLKEBME=10;typeof(NetworkManager).GetField("KIKKPMBKFAF",flags).SetValue(net,battle);
eve.SetNetClient(battle);eve.IsLocalMode=true;
root.AddComponent<ActorManager>();root.AddComponent<GameObjectPool>();
int errors=0;UnityEngine.Application.LogCallback capture=(msg,trace,type)=>{if(type==UnityEngine.LogType.Exception||type==UnityEngine.LogType.Error){errors++;if(errors<4)report.AppendLine("ERROR "+msg+" "+trace);}};UnityEngine.Application.logMessageReceived+=capture;
try{
 var targetGo=new UnityEngine.GameObject("target");targetGo.transform.parent=root.transform;targetGo.SetActive(false);targetGo.AddComponent<EveView>();targetGo.AddComponent<HumanSM>();var target=targetGo.AddComponent<PhoneLOLAttackProbeTarget>();target.m_audioClips=new UnityEngine.AudioClip[0];target.m_actorType=Actor.IJJMDPGJAEM.Hero;targetGo.SetActive(true);
 var ti=new GameServer.NEFBHKKAMJF();ti.FIGLEPBIEEJ(1);target.SetInfo(ti);target.m_team=1;target.m_hp=100000;targetGo.transform.position=UnityEngine.Vector3.forward*3;target.GetComponent<EveView>().set_viewID(801);
 foreach(var champion in new[]{"Teemo","Ezreal","Vayne"}) {
 var go=UnityEngine.Object.Instantiate(UnityEngine.Resources.Load<UnityEngine.GameObject>("hero/"+champion+"_0"));go.transform.parent=root.transform;go.SetActive(true);
 var actor=go.GetComponent<Actor>();var info=new GameServer.NEFBHKKAMJF();info.FIGLEPBIEEJ((ushort)actor.m_hero_id);actor.SetInfo(info);actor.m_hp=1000;actor.m_team=0;actor.GetComponent<EveView>().set_viewID(800);
 if(actor.m_navMeshAgent!=null)actor.m_navMeshAgent.enabled=false;
 var sm=actor.GetHumanSM();sm.SetTarget(target);
 int events=0;actor.m_actorAniEvent.add_m_attackEvent(()=>events++);
 foreach(float speed in new[]{2.5f,10f,50f,200f}){
  info.GPNKIAHCKMG.IIJMLJCIJFD().LNKFLFOGCCD=speed;
  sm.SetStateForce(StateMachine.OEOIIKMBGAG.Idle);actor.SetAnimation("idle");actor.m_attackElapsedTime=1;
  int before=events,hits=target.receivedAttacks;
  for(int frame=0;frame<240;frame++){
   actor.m_attackElapsedTime=(float)actor.m_attackElapsedTime+1f/60;
   sm.Attack();sm.DoUpdate();actor.m_animator.Update(1f/60);sm.DoUpdate();
   foreach(var missileAI in root.GetComponentsInChildren<TargetMissileAI>()){
    missileAI.Start();missileAI.m_damageParticleName="";missileAI.m_damageSoundName="";missileAI.Attack();GameObjectPool.Free(missileAI.gameObject);
   }
  }
  report.AppendLine(champion+" AS "+actor.get_m_att_speed()+" events="+(events-before)+" hits="+(target.receivedAttacks-hits)+" state="+sm.get_m_state());
  if(events-before<3 || target.receivedAttacks-hits<3)throw new System.Exception("Attack stopped at speed "+speed);
 }
 UnityEngine.Object.DestroyImmediate(go);
 }
 if(errors>0)throw new System.Exception("Animation/projectile runtime errors: "+errors);
}catch(System.Exception e){report.AppendLine("FAIL "+e);}
finally{UnityEngine.Application.logMessageReceived-=capture;nf.SetValue(null,oldNet);UnityEngine.Object.DestroyImmediate(root);}
System.IO.File.WriteAllText("../Recovery/V174AnimationVerification.txt",report.ToString());return report.ToString();
} catch(System.Exception e) { System.IO.File.WriteAllText("../Recovery/V174AnimationVerification.txt","SETUP FAIL "+e); return e.ToString(); }