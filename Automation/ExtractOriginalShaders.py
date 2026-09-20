"""Extract original shader programs from the stable APK without colliding path IDs."""
from pathlib import Path
import UnityPy, hashlib, json, re, sys
apk=Path(sys.argv[1])
out=Path(__file__).resolve().parents[1]/"Recovery"/"OriginalShaders"
out.mkdir(parents=True,exist_ok=True)
env=UnityPy.load(str(apk))
index=[]
for obj in env.objects:
    if obj.type.name!="Shader": continue
    data=obj.read()
    source=getattr(data,"m_Script",None)
    if not source: continue
    if isinstance(source,bytes): source=source.decode("utf-8")
    match=re.search(r'Shader "([^"]+)"',source)
    name=match[1] if match else getattr(data,"m_Name",str(obj.path_id))
    digest=hashlib.sha256(source.encode("utf-8")).hexdigest()
    filename=hashlib.sha256(name.encode("utf-8")).hexdigest()[:16]+"-"+digest[:12]+".shader.txt"
    (out/filename).write_text(source,encoding="utf-8")
    index.append({"name":name,"file":filename,"sha256":digest,"sourceAsset":obj.assets_file.name,"pathID":obj.path_id})
(out/"index.json").write_text(json.dumps(index,indent=2),encoding="utf-8")
print("Original shader programs:",len(index),"unique files:",len(set(x["file"] for x in index)),flush=True)
