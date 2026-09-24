"""Restore material arrays lost while converting legacy particle renderers."""
from pathlib import Path
import re,json
ROOT=Path(__file__).resolve().parents[1]
ASSETS=ROOT/"PhoneLOL-02/Assets"
ORIGINAL=Path(r"D:\A_KJ\AI\PhoneLOL-Recovery-v11511\ExportedProject\Assets")
BLOCK=re.compile(r"(?ms)^--- !u!(\d+) &(-?\d+)[^\n]*\n.*?(?=^---|\Z)")
GUID="efe1c6b2d72b8c6b1296172d06f31664"
records=[]
for path in list(ASSETS.rglob("*.prefab"))+list((ASSETS/"Scenes").glob("*.unity")):
    s=path.read_text(encoding="utf-8-sig")
    if GUID not in s:continue
    old=(ORIGINAL/path.relative_to(ASSETS)).read_text(encoding="utf-8-sig")
    original={int(m[2]):m[0] for m in BLOCK.finditer(old) if int(m[1])==26}
    edits=[]
    for m in BLOCK.finditer(s):
        if int(m[1])!=114 or GUID not in m[0]:continue
        b=original[int(m[2])]
        mats=re.search(r"(?m)^  m_Materials:[^\n]*\n(?:  -[^\n]*\n)*",b)[0]
        assert "guid:" in mats or "fileID: 0" in mats,(path,m[2])
        fixed,count=re.subn(r"(?m)^  materials:[^\n]*\n(?:  -[^\n]*\n)*",mats.replace("m_Materials:","materials:",1),m[0])
        assert count==1
        edits.append((m.start(),m.end(),fixed))
        records.append(dict(asset=path.relative_to(ROOT).as_posix(),component=int(m[2]),materials=re.findall(r"guid: (\w+)",mats)))
    for start,end,fixed in reversed(edits):s=s[:start]+fixed+s[end:]
    path.write_text(s,encoding="utf-8")
(ROOT/"Recovery/OriginalParticleMaterials.json").write_text(json.dumps(records,indent=2)+"\n",encoding="utf-8")
print("Restored original particle material arrays:",len(records))
