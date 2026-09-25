foreach(var old in UnityEngine.Object.FindObjectsByType<UnityEngine.GameObject>(UnityEngine.FindObjectsSortMode.None))if(old.name=="V1180 practice fixture")UnityEngine.Object.DestroyImmediate(old);

EveEngine.NIFAIFOJLFI.LFJBNIDJHOM();
var report=new System.Text.StringBuilder();
var flags=System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance;
System.Action<UnityEngine.Component> awake=(c)=>{if(!UnityEngine.Application.isPlaying){var m=c.GetType().GetMethod("Awake",System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.Instance);if(m!=null){try{m.Invoke(c,null);}catch(System.Exception e){throw new System.Exception("Awake "+c.GetType().Name+" "+e.InnerException,e);}}}};
var root=new UnityEngine.GameObject("V1180 practice fixture");
var network=root.AddComponent<EveUnityNetwork>();network.SetNetClient((PNDMCOBIODO)System.Activator.CreateInstance(typeof(PNDMCOBIODO)));network.IsLocalMode=true;
awake(root.AddComponent<ActorManager>());awake(root.AddComponent<GameObjectPool>());
var fakeGame=new UnityEngine.GameObject("game fixture");fakeGame.SetActive(false);fakeGame.transform.parent=root.transform;var game=fakeGame.AddComponent<MultiGameManager>();
var singleton=typeof(GameManager).GetField("MLDPFDAHKHA",System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Static);var previousGame=singleton.GetValue(null);singleton.SetValue(null,game);
var camera=UnityEngine.Camera.main;var oldCameraPosition=camera==null?UnityEngine.Vector3.zero:camera.transform.position;
if(camera==null){var cg=new UnityEngine.GameObject("fixture camera");cg.transform.parent=root.transform;cg.tag="MainCamera";camera=cg.AddComponent<UnityEngine.Camera>();}
camera.transform.position=new UnityEngine.Vector3(0,10,-10);
System.Exception failure=null;
try {
 var ag=new UnityEngine.GameObject("attacker");ag.transform.parent=root.transform;ag.SetActive(false);ag.AddComponent<EveView>();ag.AddComponent<HumanSM>();var attacker=ag.AddComponent<Actor>();attacker.m_actorType=Actor.IJJMDPGJAEM.Hero;attacker.m_audioClips=new UnityEngine.AudioClip[0];ag.SetActive(true);awake(attacker.GetComponent<EveView>());awake(attacker);
 var info=new GameServer.NEFBHKKAMJF();info.FIGLEPBIEEJ(21);attacker.SetInfo(info);attacker.GetComponent<EveView>().set_viewID(800);
 foreach(byte team in new byte[]{0,1}) {
  var home=UnityEngine.Vector3.forward*2;
  var go=UnityEngine.Object.Instantiate(UnityEngine.Resources.Load<UnityEngine.GameObject>("practice/Alistar"),home,UnityEngine.Quaternion.identity);go.transform.parent=root.transform;
  var guard=go.GetComponent<Actor>();var sm=go.GetComponent<PhoneLOLPracticeGuardSM>();awake(guard.GetComponent<EveView>());awake(guard);sm.Configure(team);
  var gi=new GameServer.NEFBHKKAMJF();gi.FIGLEPBIEEJ(1);guard.SetInfo(gi);guard.GetComponent<EveView>().set_viewID(801+team);guard.StageInit(home);
  if(guard.m_team!=team||guard.m_actorType!=Actor.IJJMDPGJAEM.Monster||!guard.GetComponent<EveView>().get_isSceneObject())throw new System.Exception("Wrong team/scene authority");
  attacker.m_team=team;int gold=(int)attacker.get_m_money();
  attacker.GetHumanSM().SetTarget(null);attacker.GetHumanSM().RetargetingAttack(true,false);
  if(attacker.GetHumanSM().get_m_target()==guard||guard.PossibleDamage(attacker))throw new System.Exception("Friendly target selectable");
  if(guard.OnAttackDamage(attacker)!=0||guard.OnDamage(attacker,10000,10000,10000)!=0)throw new System.Exception("Friendly direct damage");
  guard.OnApplyDamage(0,10000,10000,0,0,800);
  if((float)guard.m_hp!=10000||(int)attacker.get_m_money()!=gold)throw new System.Exception("Friendly replicated damage/reward");
  // A summon must be judged by its owner, even if its own team field is wrong.
  var summonGo=new UnityEngine.GameObject("summon");summonGo.transform.parent=root.transform;summonGo.SetActive(false);summonGo.AddComponent<EveView>();summonGo.AddComponent<HumanSM>();var summon=summonGo.AddComponent<Actor>();summon.m_audioClips=new UnityEngine.AudioClip[0];summonGo.SetActive(true);awake(summon.GetComponent<EveView>());awake(summon);summon.GetHumanSM().SetOwner(attacker);summon.m_team=1-team;
  if(sm.CanReceiveDamage(summon))throw new System.Exception("Friendly summon bypass");
  UnityEngine.Object.DestroyImmediate(summonGo);
  attacker.m_team=1-team;attacker.GetHumanSM().RetargetingAttack(true,false);
  if(attacker.GetHumanSM().get_m_target()!=guard||!guard.PossibleDamage(attacker)||guard.OnAttackDamage(attacker)<=0)throw new System.Exception("Enemy attack blocked");
  report.AppendLine("PASS team="+team+" friendly target/basic/skill/replicated/summon damage and reward blocked; enemy actual attack accepted");
  var clips=guard.m_audioClips;var deathClip=clips.FirstOrDefault(x=>x!=null&&x.name=="death");
  if(deathClip==null)throw new System.Exception("Alistar death sound missing");
  var animator=go.GetComponentInChildren<UnityEngine.Animator>();
  if(animator==null||!animator.runtimeAnimatorController.animationClips.Any(x=>x.name.ToLower().Contains("death")))throw new System.Exception("Death animation missing");
  for(int i=0;i<3;i++){
   gold=(int)attacker.get_m_money();guard.OnApplyDamage(0,10000,10000,0,0,800);
   if((float)guard.m_hp!=0||guard.IsLive()||sm.get_m_state()!=StateMachine.OEOIIKMBGAG.Death||(int)attacker.get_m_money()!=gold+1000)throw new System.Exception("Death state/reward");
   float due=(float)typeof(PhoneLOLPracticeGuardSM).GetField("respawnAt",flags).GetValue(sm);
   if(UnityEngine.Mathf.Abs(due-UnityEngine.Time.time-1f)>.01f)throw new System.Exception("Respawn not1 second");
   guard.OnApplyDamage(0,10000,10000,0,0,800);
   if((int)attacker.get_m_money()!=gold+1000)throw new System.Exception("Duplicate reward");
   sm.OnUpdateDeath();if(guard.IsLive())throw new System.Exception("Early respawn");
   typeof(PhoneLOLPracticeGuardSM).GetField("respawnAt",flags).SetValue(sm,UnityEngine.Time.time-0.01f);
   sm.OnUpdateDeath();
   if((float)guard.m_hp!=10000||!guard.IsLive()||sm.get_m_state()!=StateMachine.OEOIIKMBGAG.Idle||go.transform.position!=home||guard.m_dontDamage)throw new System.Exception("Owner RPC respawn failed"); attacker.GetHumanSM().SetTarget(null);attacker.GetHumanSM().RetargetingAttack(true,false);if(attacker.GetHumanSM().get_m_target()!=guard||!guard.PossibleDamage(attacker))throw new System.Exception("Enemy cannot retarget revived Alistar");
  }
  report.AppendLine("PASS team="+team+" three deaths: +1000 once, dead/untargetable for1 second, owner RPC revives at home HP10000; death animation and Alistar sound="+UnityEditor.AssetDatabase.GetAssetPath(deathClip));
  UnityEngine.Object.DestroyImmediate(go);
 }
}catch(System.Exception e){failure=e;report.AppendLine("FAIL "+e);}
finally{singleton.SetValue(null,previousGame);if(camera!=null)camera.transform.position=oldCameraPosition;UnityEngine.Object.DestroyImmediate(root);}
System.IO.File.WriteAllText("../Recovery/V1180PracticeVerification.txt",report.ToString());
if(failure!=null)throw new System.Exception(report.ToString(),failure);
return report.ToString();
