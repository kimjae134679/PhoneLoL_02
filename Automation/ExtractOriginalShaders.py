"""Extract scene/shared-asset shader records with split-file support, preserving the archive."""
from pathlib import Path
import UnityPy, hashlib, json, re, sys, zipfile
apk = Path(sys.argv[1])
out = Path(__file__).resolve().parents[1] / "Recovery" / "OriginalShaders"
out.mkdir(parents=True, exist_ok=True)
index_path = out / "index.json"
index = json.loads(index_path.read_text(encoding="utf-8")) if index_path.exists() else []
with zipfile.ZipFile(apk) as archive:
    names = set(archive.namelist())
    bases = {re.sub(r"\.split\d+$", "", n) for n in names if n.startswith("assets/bin/Data/")}
    for base in sorted(bases):
        if not (base.endswith(".assets") or re.search(r"/level\d+$", base)):
            continue
        parts = sorted((n for n in names if n.startswith(base + ".split")), key=lambda n:int(n.rsplit(".split",1)[1]))
        raw = b"".join(archive.read(n) for n in parts) if parts else archive.read(base)
        env = UnityPy.load(raw)
        for obj in env.objects:
            if obj.type.name != "Shader":
                continue
            data = obj.read()
            source = getattr(data, "m_Script", None)
            if not source:
                continue
            if isinstance(source, bytes):
                source = source.decode("utf-8")
            match = re.search(r'Shader "([^"]+)"', source)
            name = match[1] if match else getattr(data, "m_Name", str(obj.path_id))
            digest = hashlib.sha256(source.encode("utf-8")).hexdigest()
            filename = hashlib.sha256(name.encode("utf-8")).hexdigest()[:16] + "-" + digest[:12] + ".shader.txt"
            (out / filename).write_text(source, encoding="utf-8")
            index.append(dict(name=name, file=filename, sha256=digest, sourceAsset=base, pathID=obj.path_id))
records = {(x["file"], x.get("sourceAsset"), x.get("pathID")): x for x in index}
index = list(records.values())
index_path.write_text(json.dumps(index, indent=2) + "\n", encoding="utf-8")
print("Archived shader records:", len(index), "unique files:",len({x["file"] for x in index}))
print("Map shaders:", [(x["name"],x["file"]) for x in index if "Map" in x["name"]])
