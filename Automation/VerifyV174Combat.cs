EveEngine.NIFAIFOJLFI.LFJBNIDJHOM();
var report=new System.Text.StringBuilder();
var root=new UnityEngine.GameObject("V174 combat fixture");
var flags=System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance;
var network=root.AddComponent<EveUnityNetwork>();network.SetNetClient((PNDMCOBIODO)System.Activator.CreateInstance(typeof(PNDMCOBIODO)));network.IsLocalMode=true;
root.AddComponent<EveView>().set_viewID(900);
var actors=root.AddComponent<ActorManager>();var pool=root.AddComponent<GameObjectPool>();
var fakeGame=new UnityEngine.GameObject("inactive game fixture");fakeGame.SetActive(false);fakeGame.transform.parent=root.transform;
var game=fakeGame.AddComponent<MultiGameManager>();
var singleton=typeof(GameManager).GetField("MLDPFDAHKHA",System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Static);singleton.SetValue(null,game);
System.Func<string,int,Actor> make=(name,id)=>{
 var go=new UnityEngine.GameObject(name);go.transform.parent=root.transform;go.SetActive(false);go.AddComponent<EveView>();go.AddComponent<HumanSM>();
 var actor=name=="target"?(Actor)go.AddComponent<PhoneLOLAttackProbeTarget>():go.AddComponent<Actor>();actor.m_audioClips=new UnityEngine.AudioClip[0];go.SetActive(true);
 var info=new GameServer.NEFBHKKAMJF();info.FIGLEPBIEEJ((ushort)id);actor.SetInfo(info);return actor;
};
try{
 var owner=make("Teemo",21);var turret=make("Nexus",31000);var target=make("target",1);target.transform.position=UnityEngine.Vector3.forward*5;target.m_hp=100000;
 owner.GetComponent<EveView>().set_viewID(800);turret.GetComponent<EveView>().set_viewID(802);
 for(int i=0;i<1024;i++){
  var source=i%2==0?owner:turret;var missile=source.CreateMissile("attack_missile",UnityEngine.Vector3.zero,target);
  if(missile.GetHumanSM().get_m_owner()!=source||missile.GetHumanSM().get_m_target()!=target)throw new System.Exception("Missile owner/target mismatch");
  var ai=missile.GetComponent<TargetMissileAI>();ai.Start();ai.m_damageParticleName="";ai.m_damageSoundName="";
  int before=((PhoneLOLAttackProbeTarget)target).receivedAttacks;ai.Attack();
  if(((PhoneLOLAttackProbeTarget)target).receivedAttacks!=before+1)throw new System.Exception("Attack not delivered");
  missile.GetHumanSM().SetState(StateMachine.OEOIIKMBGAG.Death); missile.GetHumanSM().DoUpdate(); GameObjectPool.Free(missile.gameObject);
  if(missile.gameObject.activeSelf)throw new System.Exception("Missile death did not return to pool");
 }
 report.AppendLine("PASS 1024 alternating Teemo/Nexus creation, actual hit and state-machine death/reuse cycles");
 // The historical ID reverse map must not be able to send a different effect into a missile pool.
 var effectPrefab=new UnityEngine.GameObject("plain effect prefab");effectPrefab.transform.parent=root.transform;
 var effect=GameObjectPool.Alloc(effectPrefab);
 var reverse=(System.Collections.Generic.Dictionary<int,int>)typeof(GameObjectPool).GetField("DDKHJMOKICO",flags).GetValue(pool);
 reverse[effect.GetInstanceID()]=UnityEngine.Resources.Load<UnityEngine.GameObject>("Particle/Teemo/attack_missile").GetInstanceID();
 GameObjectPool.Free(effect);
 var healthy=owner.CreateMissile("attack_missile",UnityEngine.Vector3.zero,target);
 if(healthy.GetComponent<TeemoAttackMissileAI>()==null)throw new System.Exception("Stale ID mixed pools");
 GameObjectPool.Free(healthy.gameObject);
 report.AppendLine("PASS stale reverse-ID mapping cannot contaminate projectile pool");
 var delayed=owner.CreateMissile("attack_missile",UnityEngine.Vector3.zero,target).gameObject;
 var leases=(System.Collections.IDictionary)typeof(GameObjectPool).GetField("leases",flags).GetValue(pool);var lease=leases[delayed];
 int generation=(int)lease.GetType().GetField("generation").GetValue(lease);
 var timer=(System.Collections.IEnumerator)typeof(GameObjectPool).GetMethod("ReleaseAfter",flags).Invoke(pool,new object[]{delayed,lease,generation,1f});timer.MoveNext();
 GameObjectPool.Free(delayed);var reused=owner.CreateMissile("attack_missile",UnityEngine.Vector3.zero,target);timer.MoveNext();
 if(!reused.gameObject.activeSelf)throw new System.Exception("Old timer released a new shot");
 GameObjectPool.Free(reused.gameObject);
 report.AppendLine("PASS delayed release cannot retire a reallocated projectile");
 actors.EnsurePracticeGuard(0);actors.EnsurePracticeGuard(1);actors.EnsurePracticeGuard(0);actors.EnsurePracticeGuard(1);
 var guards=UnityEngine.Object.FindObjectsByType<PhoneLOLPracticeGuardSM>(UnityEngine.FindObjectsSortMode.None);
 if(guards.Length!=2)throw new System.Exception("Expected exactly two spawned Alistars; got "+guards.Length);
 foreach(var guard in guards){
  guard.transform.parent=root.transform;
  int visible=0;foreach(var renderer in guard.GetComponentsInChildren<UnityEngine.Renderer>())if(renderer.enabled&&renderer.gameObject.activeInHierarchy)visible++;
  if(visible==0 || (float)guard.GetComponent<Actor>().m_hp!=20000)throw new System.Exception("Guard is invisible or incorrect health");
  report.AppendLine("PASS spawned Alistar team="+guard.SpawnTeam+" visibleRenderers="+visible+" position="+guard.transform.position);
 }
 var nexusGo=new UnityEngine.GameObject("range nexus");nexusGo.transform.parent=root.transform;nexusGo.SetActive(false);nexusGo.AddComponent<EveView>();
 var nexus=nexusGo.AddComponent<NexusSM>();var nexusActor=nexusGo.AddComponent<Actor>();nexusActor.m_audioClips=new UnityEngine.AudioClip[0];nexusGo.SetActive(true);
 var ni=new GameServer.NEFBHKKAMJF();ni.FIGLEPBIEEJ(31000);nexusActor.SetInfo(ni);nexusActor.m_team=1;nexusActor.m_hp=1000;
 var stats=nexusActor.GetHeroInfo().GPNKIAHCKMG.IIJMLJCIJFD();var ti=new GameServer.NEFBHKKAMJF();ti.FIGLEPBIEEJ(30002);
 stats.IIICODNIMNN=ti.GPNKIAHCKMG.IIJMLJCIJFD().IIICODNIMNN;
 owner.m_team=0;owner.m_hp=1000;owner.transform.position=UnityEngine.Vector3.right;
 nexus.UpdateDefenseWarning(owner);
 var warning=(UnityEngine.GameObject)typeof(NexusSM).GetField("defenseWarning",flags).GetValue(nexus);
 if(warning==null||!warning.activeSelf)throw new System.Exception("Enemy range warning absent");
 owner.transform.position=UnityEngine.Vector3.right*100;nexus.UpdateDefenseWarning(owner);if(warning.activeSelf)throw new System.Exception("Warning remained outside range");
 owner.transform.position=UnityEngine.Vector3.right;owner.m_team=1;nexus.UpdateDefenseWarning(owner);if(warning.activeSelf)throw new System.Exception("Friendly warning");
 report.AppendLine("PASS nexus warning entry/exit and friendly exclusion");
}catch(System.Exception e){report.AppendLine("FAIL "+e);}
finally{singleton.SetValue(null,null);UnityEngine.Object.DestroyImmediate(root);}
System.IO.File.WriteAllText("../Recovery/V174CombatVerification.txt",report.ToString());return report.ToString();