var flags=System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance;
var root=new UnityEngine.GameObject("Practice guard contract fixture");root.SetActive(false);
try {
 var actor=root.AddComponent<Actor>();
 var guard=root.AddComponent<PhoneLOLPracticeGuardSM>();
 root.transform.position=new UnityEngine.Vector3(3,2,5);
 typeof(Actor).GetField("LFCGGKCACPP",flags).SetValue(actor,guard);
 typeof(Actor).GetField("MICGAGHIECO",flags).SetValue(actor,new HFDJCHHPKKJ(actor));
 guard.Init();
 if((float)actor.get_m_max_hp()!=100000f)throw new System.Exception("Practice maximum health mismatch");
 for(int i=0;i<3;i++){
  actor.m_hp=0;guard.SetStateForce(StateMachine.OEOIIKMBGAG.Death);
  root.transform.position=UnityEngine.Vector3.zero;
  guard.OnEnterDeath();
  if((float)actor.m_hp!=100000f||guard.get_m_state()!=StateMachine.OEOIIKMBGAG.Idle||root.transform.position!=new UnityEngine.Vector3(3,2,5))throw new System.Exception("Practice guard failed immediate respawn");
 }
 System.IO.File.WriteAllText("../Recovery/V170PracticeVerification.txt","PASS isolated guard state: HP100000; three death-to-idle revivals at original position. Scene spawning and phone rendering remain device checks.");
 return "PASS practice guard health and three immediate respawns";
}finally{UnityEngine.Object.DestroyImmediate(root);}