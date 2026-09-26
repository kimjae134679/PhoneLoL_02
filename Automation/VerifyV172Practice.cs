EveEngine.NIFAIFOJLFI.LFJBNIDJHOM();
var report=new System.Text.StringBuilder();
UnityEngine.Application.LogCallback capture=(message,trace,type)=>{if(type==UnityEngine.LogType.Exception)report.AppendLine(message+" "+trace);};
UnityEngine.Application.logMessageReceived+=capture;
var root=new UnityEngine.GameObject("V172 guard fixture");
var network=root.AddComponent<EveUnityNetwork>();network.SetNetClient((PNDMCOBIODO)System.Activator.CreateInstance(typeof(PNDMCOBIODO)));network.IsLocalMode=true;
root.AddComponent<ActorManager>();root.AddComponent<GameObjectPool>();
try{
 var attackerGo=new UnityEngine.GameObject("attacker");attackerGo.transform.parent=root.transform;attackerGo.SetActive(false);
 attackerGo.AddComponent<EveView>();attackerGo.AddComponent<HumanSM>();var attacker=attackerGo.AddComponent<Actor>();attacker.m_actorType=Actor.IJJMDPGJAEM.Hero;attacker.m_audioClips=new UnityEngine.AudioClip[0];attackerGo.SetActive(true);
 var info=new GameServer.NEFBHKKAMJF();info.FIGLEPBIEEJ(21);attacker.SetInfo(info);attacker.GetComponent<EveView>().set_viewID(800);
 var guardGo=UnityEngine.Object.Instantiate(UnityEngine.Resources.Load<UnityEngine.GameObject>("practice/Alistar"),UnityEngine.Vector3.forward*2,UnityEngine.Quaternion.identity);guardGo.transform.parent=root.transform;
 var guard=guardGo.GetComponent<Actor>();var sm=guardGo.GetComponent<PhoneLOLPracticeGuardSM>();sm.Configure(0);
 var guardInfo=new GameServer.NEFBHKKAMJF();guardInfo.FIGLEPBIEEJ(1);guard.SetInfo(guardInfo);guard.GetComponent<EveView>().set_viewID(801);
 if(guard.m_actorType!=Actor.IJJMDPGJAEM.Monster||guard.m_team!=2||!guard.GetComponent<EveView>().get_isSceneObject())throw new System.Exception("Invalid monster/authority configuration");
 foreach(int team in new[]{0,1}){
  attacker.m_team=team;attacker.GetHumanSM().RetargetingAttack(true,false);
  if(attacker.GetHumanSM().get_m_target()!=guard||!guard.PossibleDamage(attacker))throw new System.Exception("Team cannot attack guard: "+team);
  report.AppendLine("PASS team "+team+" can select and damage neutral Monster Alistar");
 }
 float before=guard.m_hp;
 float damage=guard.OnAttackDamage(attacker);
 if(damage<=0 || (float)guard.m_hp>=before)throw new System.Exception("Actual attack did not lower HP: result="+damage+" hp="+guard.m_hp+" before="+before);
 report.AppendLine("PASS actual OnAttackDamage: "+before+" -> "+guard.m_hp+" damage="+damage);
 for(int i=0;i<3;i++){int gold=(int)attacker.get_m_money();guard.OnApplyDamage(0,20000,20000,0,0,800);if((float)guard.m_hp!=20000f||sm.get_m_state()!=StateMachine.OEOIIKMBGAG.Idle)throw new System.Exception("Immediate revival failed");if((int)attacker.get_m_money()!=gold+1000)throw new System.Exception("Kill gold must increase by exactly 1000");}
 report.AppendLine("PASS three lethal damage applications: HP20000 revival and exactly +1000 gold per kill");
 var blue=PhoneLOLPracticeGuardSM.GetSpawnPosition(new UnityEngine.Vector3(-37,3,-37),new UnityEngine.Vector3(37,3,37),0);
 var red=PhoneLOLPracticeGuardSM.GetSpawnPosition(new UnityEngine.Vector3(37,3,37),new UnityEngine.Vector3(-37,3,-37),1);
 if(blue.x<=-17||red.x>=17||UnityEngine.Mathf.Abs(blue.x+red.x)>0.01f)throw new System.Exception("Distant mirrored placement failed");
 report.AppendLine("PASS mirrored distant placement: blue="+blue+" red="+red);
}catch(System.Exception e){report.AppendLine("FAIL "+e);}
finally{UnityEngine.Application.logMessageReceived-=capture;UnityEngine.Object.DestroyImmediate(root);}
System.IO.File.WriteAllText("../Recovery/V172PracticeVerification.txt",report.ToString());return report.ToString();