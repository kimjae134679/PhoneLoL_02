"""Write modern controller assets while retaining their existing GUIDs."""
from pathlib import Path
import json
ROOT=Path(__file__).resolve().parents[1]
data=json.loads((ROOT/"Recovery/OriginalControllers.json").read_text(encoding="utf-8"))
assert not data["problems"],data["problems"]
def ref(i):return "{fileID: "+str(i)+"}"
def header(kind,i,name):
 return [f"--- !u!{kind} &{i}",name+":","  m_ObjectHideFlags: "+str(0 if kind==91 else 1),"  m_CorrespondingSourceObject: {fileID: 0}","  m_PrefabInstance: {fileID: 0}","  m_PrefabAsset: {fileID: 0}"]
count=0;transitions=0
for row in data["controllers"]:
 original=row["data"];c=original["m_Controller"];strings=dict(original["m_TOS"])
 assert len(c["m_LayerArray"])==len(c["m_StateMachineArray"])==1
 layer=c["m_LayerArray"][0]["data"];sm=c["m_StateMachineArray"][0]["data"]
 assert not sm["m_AnyStateTransitionConstantArray"]
 states=[x["data"] for x in sm["m_StateConstantArray"]]
 out=["%YAML 1.1","%TAG !u! tag:unity3d.com,2011:"]
 out+=header(91,9100000,"AnimatorController")
 out+=["  m_Name: "+json.dumps(original["m_Name"]),"  serializedVersion: 5"]
 params=c["m_Values"]["data"]["m_ValueArray"]
 out+=["  m_AnimatorParameters:"+("" if params else " []")]
 for p in params:
  defaults=c["m_DefaultValues"]["data"];kind=p["m_Type"]
  out+=["  - m_Name: "+json.dumps(strings[p["m_ID"]]),"    m_Type: "+str(kind),
        "    m_DefaultFloat: "+str(defaults["m_FloatValues"][p["m_Index"]] if kind==1 else 0),
        "    m_DefaultInt: "+str(defaults["m_IntValues"][p["m_Index"]] if kind==3 else 0),
        "    m_DefaultBool: "+str(int(defaults["m_BoolValues"][p["m_Index"]]) if kind in (4,9) else 0),
        "    m_Controller: {fileID: 9100000}"]
 out+=["  m_AnimatorLayers:","  - serializedVersion: 5","    m_Name: "+json.dumps(strings[layer["m_Binding"]]),
       "    m_StateMachine: {fileID: 110700000}","    m_Mask: {fileID: 0}","    m_Motions: []","    m_Behaviours: []",
       "    m_BlendingMode: "+str(layer["(int&)m_LayerBlendingMode"]),"    m_SyncedLayerIndex: -1",
       "    m_DefaultWeight: 1","    m_IKPass: "+str(int(layer["m_IKPass"])),
       "    m_SyncedLayerAffectsTiming: "+str(int(layer["m_SyncedLayerAffectsTiming"])),"    m_Controller: {fileID: 9100000}"]
 out+=header(1107,110700000,"AnimatorStateMachine")
 out+=["  serializedVersion: 6","  m_Name: "+json.dumps(strings[layer["m_Binding"]]),"  m_ChildStates:"]
 for i in range(len(states)):out+=["  - serializedVersion: 1","    m_State: "+ref(110200000+i),f"    m_Position: {{x: {i%4*240}, y: {i//4*80}, z: 0}}"]
 out+=["  m_ChildStateMachines: []","  m_AnyStateTransitions: []","  m_EntryTransitions: []","  m_StateMachineTransitions: {}",
       "  m_StateMachineBehaviours: []","  m_AnyStatePosition: {x: 50, y: 20, z: 0}","  m_EntryPosition: {x: 50, y: 120, z: 0}",
       "  m_ExitPosition: {x: 800, y: 120, z: 0}","  m_ParentStateMachinePosition: {x: 800, y: 20, z: 0}",
       "  m_DefaultState: "+ref(110200000+sm["m_DefaultState"])]
 transition_id=110100000
 for i,state in enumerate(states):
  assert len(state["m_BlendTreeConstantArray"])==1
  nodes=state["m_BlendTreeConstantArray"][0]["data"]["m_NodeArray"];assert len(nodes)==1
  node=nodes[0]["data"];assert not node["m_ChildIndices"]
  leaves=[x for x in state["m_LeafInfoArray"] if node["m_ClipID"] in x["m_IDArray"]];assert len(leaves)==1
  leaf=leaves[0];clip_index=leaf["m_IndexOffset"]+leaf["m_IDArray"].index(node["m_ClipID"])
  clip=row["clips"][clip_index];assert clip is not None
  trans=[x["data"] for x in state["m_TransitionConstantArray"]]
  out+=header(1102,110200000+i,"AnimatorState")
  out+=["  serializedVersion: 6","  m_Name: "+json.dumps(strings[state["m_NameID"]]),
        "  m_Speed: "+str(state["m_Speed"]),"  m_CycleOffset: "+str(state["m_CycleOffset"]),
        "  m_Transitions:"+("" if trans else " []")]
  for j in range(len(trans)):out+=["  - "+ref(transition_id+j)]
  out+=["  m_StateMachineBehaviours: []","  m_Position: {x: 0, y: 0, z: 0}","  m_IKOnFeet: "+str(int(state["m_IKOnFeet"])),
        "  m_WriteDefaultValues: 1","  m_Mirror: "+str(int(state["m_Mirror"])),"  m_SpeedParameterActive: 0","  m_MirrorParameterActive: 0",
        "  m_CycleOffsetParameterActive: 0","  m_TimeParameterActive: 0",
        "  m_Motion: {fileID: 7400000, guid: "+clip["guid"]+", type: 2}",
        "  m_Tag: "+json.dumps(strings.get(state["m_TagID"],"")),"  m_SpeedParameter:","  m_MirrorParameter:","  m_CycleOffsetParameter:","  m_TimeParameter:"]
  for tr in trans:
   conditions=[x["data"] for x in tr["m_ConditionConstantArray"]];assert len(conditions)==1 and conditions[0]["m_ConditionMode"]==5
   dest=tr["m_DestinationState"];assert 0<=dest<len(states)
   out+=header(1101,transition_id,"AnimatorStateTransition")
   out+=["  m_Name:","  m_Conditions: []","  m_DstStateMachine: {fileID: 0}","  m_DstState: "+ref(110200000+dest),
         "  m_Solo: 0","  m_Mute: 0","  m_IsExit: 0","  serializedVersion: 3",
         "  m_TransitionDuration: "+str(tr["m_TransitionDuration"]),"  m_TransitionOffset: "+str(tr["m_TransitionOffset"]),
         "  m_ExitTime: "+str(conditions[0]["m_ExitTime"]),"  m_HasExitTime: 1","  m_HasFixedDuration: 0",
         "  m_InterruptionSource: "+str(0 if tr["m_Atomic"] else 1),"  m_OrderedInterruption: 1",
         "  m_CanTransitionToSelf: "+str(int(tr["m_CanTransitionToSelf"]))]
   transition_id+=1;transitions+=1
  count+=1
 (ROOT/"PhoneLOL-02"/row["path"]).write_text("\n".join(out)+"\n",encoding="utf-8")
print("Restored",len(data["controllers"]),"controllers",count,"states",transitions,"transitions")
