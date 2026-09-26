"""Recover original runtime controller states and transitions from the stable APK."""
from pathlib import Path
import collections,json,re,sys,hashlib
from RecoverOriginalActorData import Archive,ROOT,ASSETS
APK=Path(r"C:\Users\user\Documents\MultiGod\PhoneLOL_v11511_SAFE_OUTPUT\PhoneLOL_v1.15.11.apk")
def name(text):
    value=re.search(r"(?m)^  m_Name: (.*)",text)[1].strip()
    return json.loads(value) if value.startswith('"') else value
def guid(path):
    return re.search(r"guid: (\w+)",Path(str(path)+".meta").read_text())[1]
def bindings(data):
    return tuple((x["path"],x["attribute"],x["classID"],x["customType"],x["isPPtrCurve"]) for x in data)
def run():
    archive=Archive(APK)
    clips=collections.defaultdict(list)
    for path in (ASSETS/"AnimationClip").glob("*.anim"):
        text=path.read_text(encoding="utf-8-sig")
        section=text.split("  m_ClipBindingConstant:",1)[-1].split("  m_AnimationClipSettings:",1)[0]
        b=tuple(tuple(map(int,m)) for m in re.findall(
            r"- path: (\d+)\s+attribute: (\d+)\s+script: \{fileID: 0\}\s+classID: (\d+)\s+customType: (\d+)\s+isPPtrCurve: (\d+)",section))
        stop=re.search(r"m_StopTime: ([^\r\n]+)",text)
        if stop: clips[(name(text),b)].append((path,float(stop[1]),text))
    controllers=collections.defaultdict(list)
    for path in (ASSETS/"AnimatorController").glob("*.controller"):
        controllers[name(path.read_text(encoding="utf-8-sig"))].append(path)
    records=json.loads((ROOT/"Recovery/OriginalActorData.json").read_text(encoding="utf-8"))["actors"]
    seen=set(); output=[]; problems=[]
    for src_name in sorted({x["sourceAsset"] for x in records}):
        source=archive.load(src_name)
        for obj in source.objects.values():
            if obj.type.name!="Animator":continue
            pointer=obj.read_typetree()["m_Controller"]
            co=archive.resolve(source,pointer)
            if co is None:continue
            key=(co.assets_file.name,co.path_id)
            if key in seen:continue
            seen.add(key);data=co.read_typetree()
            targets=controllers[data["m_Name"]]
            if len(targets)!=1:
                problems.append(["controller",data["m_Name"],len(targets)]);continue
            mapped=[]
            for ptr in data["m_AnimationClips"]:
                clip=archive.resolve(co.assets_file,ptr)
                if clip is None: mapped.append(None);continue
                c=clip.read_typetree()
                sig=(c["m_Name"],bindings(c["m_ClipBindingConstant"]["genericBindings"]))
                stop=c["m_MuscleClip"]["m_StopTime"]
                matches=[x for x in clips[sig] if abs(x[1]-stop)<0.0001]
                if len(matches)>1 and sig[1] and sig[1][0][1]==1:
                    expected=[v["m_Start"] for v in c["m_MuscleClip"]["m_ValueArrayDelta"][:3]]
                    def initial_position(text):
                        section=text.split("  m_PositionCurves:",1)[1]
                        m=re.search(r"value: \{x: ([^,]+), y: ([^,]+), z: ([^}]+)\}",section)
                        return list(map(float,m.groups())) if m else []
                    matches=[x for x in matches if len(initial_position(x[2]))==3 and
                             all(abs(u-v)<0.000001 for u,v in zip(initial_position(x[2]),expected))]
                if len(matches)>1:
                    # Identical exported curves are interchangeable; differing curves are not.
                    hashes={hashlib.sha256(re.sub(r"m_Name:.*","m_Name:",x[2]).encode()).hexdigest() for x in matches}
                    if len(hashes)>1:matches=[]
                if not matches:
                    problems.append(["clip",data["m_Name"],c["m_Name"],stop,len(clips[sig])]);mapped.append(None)
                else: mapped.append({"path":str(matches[0][0].relative_to(ROOT/"PhoneLOL-02")).replace("\\","/"),"guid":guid(matches[0][0])})
            output.append({"path":str(targets[0].relative_to(ROOT/"PhoneLOL-02")).replace("\\","/"),
                "sourceAsset":co.assets_file.name,"sourcePathID":co.path_id,"clips":mapped,"data":data})
    result={"controllers":output,"problems":problems}
    (ROOT/"Recovery/OriginalControllers.json").write_text(json.dumps(result,ensure_ascii=True,indent=2),encoding="utf-8")
    print("Controllers",len(output),"problems",len(problems))
    print(json.dumps(problems[:18],ensure_ascii=True))
    for item in output[:3]:
        c=item["data"]["m_Controller"]
        print(item["path"],"layers",len(c["m_LayerArray"]),"machines",len(c["m_StateMachineArray"]))
if __name__=="__main__":run()
