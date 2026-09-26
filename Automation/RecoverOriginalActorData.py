"""Restore Actor fields from the stable APK without inventing gameplay data."""
from pathlib import Path
import argparse
import collections
import hashlib
import json
import re
import zipfile
import UnityPy
from UnityPy.helpers.TypeTreeGenerator import TypeTreeGenerator

ROOT = Path(__file__).resolve().parents[1]
ASSETS = ROOT / "PhoneLOL-02/Assets"
ACTOR_GUID = "dbe4d2a6e91eb90db84d1482ed545a1c"
BLOCK = re.compile(r"(?ms)^--- !u!(\d+) &(-?\d+)[^\r\n]*\r?\n.*?(?=^---|\Z)")
SCALARS = ("m_hero_id", "m_heroCostumeID", "m_selfCreateHeroInfo", "m_team",
           "m_actorType", "m_lifeTime", "m_moveSpeed", "m_dontDamage",
           "m_dontHeal", "m_useGameObjectPool")

def reference(block, name):
    return int(re.search(r"(?m)^  " + name + r": \{fileID: (-?\d+)", block)[1])

def unity_name(block):
    value = re.search(r"(?m)^  m_Name: (.*)$", block)[1].rstrip("\r")
    return json.loads(value) if value.startswith('"') else value

class Archive:
    def __init__(self, path):
        self.zip = zipfile.ZipFile(path)
        self.names = set(self.zip.namelist())
        self.env = UnityPy.Environment()
        self.files = {}
        self.generator = TypeTreeGenerator("4.7.1f1")
        for name in sorted(self.names):
            if name.startswith("assets/bin/Data/Managed/") and name.endswith(".dll"):
                self.generator.load_dll(self.zip.read(name))
        self.actor_node = self.generator.get_nodes_up("Assembly-CSharp", "Actor")
        # The patched DLL added a runtime-only tail field absent from the stable assets.
        self.actor_fields = list(self.actor_node.m_Children[4:-1])
        assert self.actor_node.m_Children[-1].m_Name == "m_v093RuneGoldTick"

    def load(self, name):
        name = name.replace("\\", "/").rsplit("/", 1)[-1]
        if name not in self.files:
            base = "assets/bin/Data/" + name
            parts = sorted((n for n in self.names if n.startswith(base + ".split")),
                           key=lambda n: int(n.rsplit(".split", 1)[1]))
            raw = b"".join(self.zip.read(n) for n in parts) if parts else self.zip.read(base)
            self.files[name] = self.env.load_file(raw, name=name)
        return self.files[name]

    def resolve(self, source, pointer):
        if not pointer["m_PathID"]:
            return None
        target = source if pointer["m_FileID"] == 0 else self.load(
            source.externals[pointer["m_FileID"] - 1].path)
        return target.objects[pointer["m_PathID"]]

    def actors(self, source):
        for obj in source.objects.values():
            if obj.type.name != "MonoBehaviour":
                continue
            base = obj.read_typetree(check_read=False)
            script = self.resolve(source, base["m_Script"])
            if script is None or script.read().m_ClassName != "Actor":
                continue
            # Built-in headers supply the correct byte alignment for Unity 4.
            self.actor_node.m_Children = list(obj._get_typetree_node().m_Children[:4]) + self.actor_fields
            yield obj, obj.read_typetree(self.actor_node, check_read=True)

def position_key(values):
    return ",".join(str(round(float(v), 3) + 0.0) for v in values)

def source_paths(source):
    names, transforms, by_go = {}, {}, {}
    for obj in source.objects.values():
        if obj.type.name == "GameObject":
            names[obj.path_id] = obj.read().m_Name
        elif obj.type.name in ("Transform", "RectTransform"):
            data = obj.read_typetree()
            transforms[obj.path_id] = data
            by_go[data["m_GameObject"]["m_PathID"]] = obj.path_id

    def path(go):
        result, seen = [], set()
        while go:
            if go in seen:
                raise ValueError("Cyclic transform hierarchy")
            seen.add(go)
            pos = transforms[by_go[go]]["m_LocalPosition"]
            result.append(names[go] + "@" + position_key(pos[k] for k in ("x", "y", "z")))
            father = transforms[by_go[go]]["m_Father"]
            if father["m_FileID"]:
                raise ValueError("External transform parent requires explicit mapping")
            go = transforms[father["m_PathID"]]["m_GameObject"]["m_PathID"] if father["m_PathID"] else 0
        return "/".join(reversed(result))
    return {go: path(go) for go in names}

def local_objects(text):
    blocks = {int(m[2]): (int(m[1]), m.group(), m.start(), m.end()) for m in BLOCK.finditer(text)}
    names = {i: unity_name(v[1]) for i, v in blocks.items() if v[0] == 1}
    transforms = {i: (reference(v[1], "m_GameObject"), reference(v[1], "m_Father"))
                  for i, v in blocks.items() if v[0] in (4, 224)}
    by_go = {go: tr for tr, (go, _) in transforms.items()}

    def path(go):
        result, seen = [], set()
        while go:
            if go in seen:
                raise ValueError("Cyclic local hierarchy")
            seen.add(go)
            raw = re.search(r"m_LocalPosition: \{x: ([^,]+), y: ([^,]+), z: ([^}]+)\}", blocks[by_go[go]][1])
            result.append(names[go] + "@" + position_key(raw.groups()))
            father = transforms[by_go[go]][1]
            go = transforms[father][0] if father else 0
        return "/".join(reversed(result))
    return blocks, {go: path(go) for go in names}

def recover(archive, local, source, audio, records):
    text = local.read_text(encoding="utf-8-sig")
    blocks, local_paths = local_objects(text)
    source_go_paths = source_paths(source)
    inverse = collections.defaultdict(list)
    for go, path in local_paths.items():
        inverse[path].append(go)
    originals = collections.defaultdict(list)
    for obj, data in archive.actors(source):
        originals[source_go_paths[data["m_GameObject"]["m_PathID"]]].append((obj, data))
    edits = []
    for local_id, (kind, block, start, end) in blocks.items():
        if kind != 114 or ACTOR_GUID not in block:
            continue
        if re.search(r"(?m)^  m_hero_id:", block):
            raise ValueError("Actor already contains serialized fields: " + str(local))
        local_go = reference(block, "m_GameObject")
        path = local_paths[local_go]
        matches = originals[path]
        if len(matches) != 1:
            raise ValueError("Ambiguous/missing original Actor at " + path)
        obj, data = matches[0]
        fields = [f"  {key}: {data[key]}" for key in SCALARS]
        hud = archive.resolve(source, data["m_damageHUDPosition"])
        hud_id = 0
        if hud is not None:
            if hud.assets_file != source:
                raise ValueError("External HUD reference requires explicit mapping")
            candidates = inverse[source_go_paths[hud.path_id]]
            if len(candidates) != 1:
                raise ValueError("Ambiguous HUD path: " + source_go_paths[hud.path_id])
            hud_id = candidates[0]
        fields.append(f"  m_damageHUDPosition: {{fileID: {hud_id}}}")
        clips = []
        for pointer in data["m_audioClips"]:
            clip = archive.resolve(source, pointer)
            if clip is None:
                clips.append(("null", None))
                continue
            name = clip.read().m_Name
            candidates = audio[name]
            if len(candidates) != 1:
                raise ValueError(f"Ambiguous audio {name!r}: {candidates}")
            guid = re.search(r"(?m)^guid: (\w+)", Path(str(candidates[0]) + ".meta").read_text())[1]
            clips.append((name, guid))
        fields.append("  m_audioClips:" if clips else "  m_audioClips: []")
        for _, guid in clips:
            fields.append(f"  - {{fileID: 8300000, guid: {guid}, type: 3}}" if guid else "  - {fileID: 0}")
        # ObscuredByte has no serialized child fields in the stable assets.
        assert data.get("m_skillPoint") == {}
        replacement = block.rstrip() + "\n" + "\n".join(fields) + "\n"
        edits.append((start, end, replacement))
        records.append(dict(asset=local.relative_to(ROOT).as_posix(), component=local_id,
                            sourceAsset=source.name, sourcePathID=obj.path_id, objectPath=path,
                            values={k: data[k] for k in SCALARS}, hudFileID=hud_id,
                            audio=[name for name, _ in clips]))
    for start, end, replacement in sorted(edits, reverse=True):
        text = text[:start] + replacement + text[end:]
    return text

def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("apk", type=Path)
    parser.add_argument("--apply", action="store_true")
    args = parser.parse_args()
    digest = hashlib.sha256(args.apk.read_bytes()).hexdigest()
    assert digest == "6f4a76b66a730a8ae49d5c6c9309990722f58da25eb64c0fd063b49f296cbe2f"
    archive = Archive(args.apk)
    main_data = archive.load("mainData")
    resources = next(o.read_typetree()["m_Container"] for o in main_data.objects.values()
                     if o.type.name == "ResourceManager")
    resources = {name.lower(): ptr for name, ptr in resources}
    audio = collections.defaultdict(list)
    for file in (ASSETS / "AudioClip").iterdir():
        if file.suffix != ".meta":
            audio[file.stem].append(file)
    targets = []
    for local in sorted((ASSETS / "Resources").rglob("*.prefab")):
        if ACTOR_GUID not in local.read_text(encoding="utf-8-sig"):
            continue
        key = local.relative_to(ASSETS / "Resources").with_suffix("").as_posix().lower()
        obj = archive.resolve(main_data, resources[key])
        targets.append((local, obj.assets_file))
    levels = next(o.read_typetree()["levels"] for o in main_data.objects.values()
                  if o.type.name == "BuildSettings")
    for index, name in enumerate(levels):
        local = ROOT / "PhoneLOL-02" / name
        if ACTOR_GUID in local.read_text(encoding="utf-8-sig"):
            targets.append((local, archive.load("mainData" if index == 0 else "level" + str(index - 1))))
    prepared, records, errors = [], [], []
    for local, source in targets:
        try:
            prepared.append((local, recover(archive, local, source, audio, records)))
        except Exception as exc:
            errors.append({"asset": local.relative_to(ROOT).as_posix(), "error": str(exc)})
    report = {"apkSha256": digest, "actors": records, "errors": errors}
    report_path = ROOT / "Recovery/OriginalActorData.json"
    report_path.write_text(json.dumps(report, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
    print(json.dumps({"assets": len(targets), "prepared": len(prepared),
                      "actors": len(records), "errors": errors[:15]}, ensure_ascii=False), flush=True)
    if errors:
        raise SystemExit("No assets modified; resolve the recorded mapping errors first.")
    if args.apply:
        for local, text in prepared:
            local.write_text(text, encoding="utf-8", newline="\n")
        print("Restored original Actor fields in", len(prepared), "assets.", flush=True)

if __name__ == "__main__":
    main()
