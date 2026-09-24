"""Attach original baked lighting records without rewriting recovered scene assets."""
from pathlib import Path
import re
ROOT=Path(__file__).resolve().parents[1]
for name in ("MultiGame","MtmGame"):
    path=ROOT/f"PhoneLOL-02/Assets/Scenes/{name}.unity"
    text=path.read_text(encoding="utf-8-sig")
    assert "03e1bc00b32942f68b010be0777a630e" not in text,"Already recovered"
    maps=re.findall(r"- m_Lightmap: (\{[^}]+\})",text)
    assert len(maps)==2
    batch_ids=set()
    for line in (ROOT/"Recovery/StaticBatchReplacements.txt").read_text().splitlines():
        scene,_,renderer,_=line.split("|")
        if scene.endswith("/"+name+".unity"):batch_ids.add(int(renderer))
    bindings=[]
    for m in re.finditer(r"(?ms)^--- !u!(\d+) &(\d+)\r?\n(.*?)(?=^---|\Z)",text):
        kind,obj,block=int(m[1]),int(m[2]),m[3]
        if kind not in (23,137,218):continue
        index=re.search(r"m_LightmapIndex: (\d+)",block)
        if not index or int(index[1])>=len(maps):continue
        st=re.search(r"m_LightmapTilingOffset: (\{[^}]+\})",block)
        assert st,(name,obj)
        value="{x: 1, y: 1, z: 0, w: 0}" if obj in batch_ids else st[1]
        bindings+=["  - renderer: {fileID: "+str(obj if kind!=218 else 0)+"}",
                   "    terrain: {fileID: "+str(obj if kind==218 else 0)+"}",
                   "    index: "+index[1],"    scaleOffset: "+value]
    assert len(bindings)>100
    go=900000001;tr=900000002;mono=900000003
    assert not re.search(r"&90000000[123]",text)
    extra=f"""--- !u!1 &{go}
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {{fileID: 0}}
  m_PrefabInstance: {{fileID: 0}}
  m_PrefabAsset: {{fileID: 0}}
  serializedVersion: 6
  m_Component:
  - component: {{fileID: {tr}}}
  - component: {{fileID: {mono}}}
  m_Layer: 0
  m_Name: OriginalBakedLighting
  m_TagString: Untagged
  m_IsActive: 1
--- !u!4 &{tr}
Transform:
  m_ObjectHideFlags: 0
  m_GameObject: {{fileID: {go}}}
  serializedVersion: 2
  m_LocalRotation: {{x: 0, y: 0, z: 0, w: 1}}
  m_LocalPosition: {{x: 0, y: 0, z: 0}}
  m_LocalScale: {{x: 1, y: 1, z: 1}}
  m_Children: []
  m_Father: {{fileID: 0}}
--- !u!114 &{mono}
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_GameObject: {{fileID: {go}}}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {{fileID: 11500000, guid: 03e1bc00b32942f68b010be0777a630e, type: 3}}
  m_Name:
  m_EditorClassIdentifier:
  maps:
"""
    extra+="".join("  - "+m+"\n" for m in maps)
    extra+="  bindings:\n"+"\n".join(bindings)+"\n"
    path.write_text(text.rstrip()+"\n"+extra,encoding="utf-8")
    print(name,"lightmaps",len(maps),"bindings",len(bindings)//4)
